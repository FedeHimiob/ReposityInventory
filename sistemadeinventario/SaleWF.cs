using Data.Entities;
using Data.EnumInv;
using Data.Servicies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Data.EnumInv.EnumInv;


namespace SistemaDeInventario
{
    public partial class SaleWF : Form
    {
        private const double V = 0.15;

        private List<Product> temporaryProductList = new List<Product>();
        public EnumInv.OperationCashOrCredit Operation { get; set; }
        public int[] ProductsSelected { get; set; }

        public string CustomerCliente { get; set; }

        private double IVA = V;

        private decimal Total { get; set; }

        private int ClientId { get; set; }

        public int SaleId { get; set; }

        public SaleWF()
        {
            InitializeComponent();
            dgvProducts.AutoGenerateColumns = false;
            this.txtCustomerDocument.KeyPress += new KeyPressEventHandler(CaptureKeyPress);
           
            SaleService service = new SaleService();
            var salelist = service.GetSale();
            var saleId = (from s in salelist select s.Id).Max();        
            this.txtInVoice.Text = $"FAC000{(saleId+1)}";
        }


        public void LoadProductsInvoice(int[] productList)
        {
            try
            {
                ProductService productService = new ProductService();
                var pList = productService.GetProducts(productList);

                foreach (var p in pList)
                {
                    if (!temporaryProductList.Any(x => x.Id == p.Id))
                    {
                        temporaryProductList.Add(p);
                    }
                }
                LoaddtvProducts();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void LoaddtvProducts()
        {
            try
            {
                dgvProducts.DataSource = null;

                dgvProducts.DataSource = temporaryProductList;

                foreach (Product p in temporaryProductList)
                {
                    if (p.SubTotal != 0)
                    {
                        int index = temporaryProductList.IndexOf(p);
                        var dataRow = dgvProducts.Rows[index];

                        var SubTotalRow = p.Price * p.SubTotal;
                        dataRow.Cells["SubTotalItem"].Value = SubTotalRow;
                    }
                }
                dgvProducts.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            form.LoadInvoiceProducts += LoadInvoiceProducts;            
            form.ShowDialog(this);
        }
        
        public void LoadInvoiceProducts(int[] ProductList)
        {
            LoadProductsInvoice(ProductList);
        }

        private void btnCostCalculation_Click(object sender, EventArgs e)
        {
            try
            {
                decimal[] price = new decimal[dgvProducts.RowCount];
                int[] quantity = new int[dgvProducts.RowCount];
                decimal subtotal = 0;
                decimal costIVA = 0;
                decimal total = 0;

                //Captura los valores de Price y Quantity
                for (int i = 0; i < dgvProducts.RowCount; i++)
                {
                    var row = (DataGridViewRow)dgvProducts.Rows[i];
                    var quan = row.Cells["Quantity"].Value.ToString();
                    var pri = row.Cells["Price"].Value.ToString();

                    if ((Int32.TryParse(quan, out int Q)) && (quan != "0"))
                    {
                        quantity[i] = Q;
                    }
                    else if (Int32.TryParse(quan, out int q) && !(quan != "0"))
                    {
                        MessageBox.Show("CANTIDAD DE PRODUCTOS NO INTRODUCIDA");
                        return;
                    }
                    if (Decimal.TryParse(pri, out decimal p))
                    {
                        price[i] = p;
                    }
                    else
                    {
                        return;
                    }
                }

                for (int i = 0; i < dgvProducts.RowCount; i++)
                {
                    decimal ps = price[i] * Convert.ToDecimal(quantity[i]);
                    subtotal += ps;
                }

                txtSubTotal.Text = subtotal.ToString();
                costIVA = subtotal * Convert.ToDecimal(IVA);
                txtIVA.Text = costIVA.ToString();
                total = costIVA + subtotal;
                this.Total = total;
                txtTotal.Text = total.ToString();
                CalculoDeCostoFinal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddCliente form = new AddCliente();
            form.LoadClient += LoadInvoiceClient;
            form.ShowDialog(this);
        }

        public void LoadInvoiceClient(string documentIdentity)
        {
            LoadClientInvoice(documentIdentity);
        }
        private void LoadClientInvoice(string documentIdentity)
        {
            try
            {
                ClientService service = new ClientService();
                var result = service.GetClientByDocumentIdentity(documentIdentity);

                txtName.Text = result.Name;
                txtCustomerDocument.Text = result.DocumentIdentity;
                txtCustomerphone.Text = result.Phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btbVerification_Click(object sender, EventArgs e)
        {
            try
            {
                var r = txtRiforCi.Text;
                if (r != "") { VerificarCliente(); }
                else { MessageBox.Show($"Introduzca un numero de documento", "Notificacion", MessageBoxButtons.OK); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void VerificarCliente()
        {
            try
            {
                ClientService service = new ClientService();
                string r = cbRiforCi.SelectedItem.ToString();
                string DocumentIdentity = "";
                int resul = 0;

                if (this.CustomerCliente != null) { DocumentIdentity = this.CustomerCliente + txtCustomerDocument.Text; }

                if (Int32.TryParse(txtCustomerDocument.Text.ToString(), out resul))
                {
                    var client = service.GetClientByDocumentIdentity(DocumentIdentity);

                    if (client != null)
                    {
                        txtName.Text = client.Name;
                        txtCustomerDocument.Text = client.DocumentIdentity.ToString();
                        txtRiforCi.Visible = false;
                        txtCustomerphone.Text = client.Phone;
                    }
                    else
                    {
                        MessageBox.Show($"Cliente no registrado", "Notificacion", MessageBoxButtons.OK);
                        txtName.Text = "";
                        txtCustomerDocument.Text = "";
                        txtCustomerphone.Text = "";
                        return;
                    }

                }
                else
                {
                    MessageBox.Show($"Documento invalido", "Notificacion", MessageBoxButtons.OK);
                    txtName.Text = "";
                    txtCustomerDocument.Text = "";
                    txtCustomerphone.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }


        private void CaptureKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txtCustomerDocument.Focused)
                    {
                        if (!string.IsNullOrEmpty(txtCustomerDocument.Text))
                        {
                            VerificarCliente();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }


        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txtAmountPaid.Focused)
                    {
                        CalculoDeCostoFinal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void CellEndEditAmountInGrid(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProductsEntryService service = new ProductsEntryService();

                var rowIndex = e.RowIndex;
                var dataRow = dgvProducts.Rows[rowIndex];
                decimal amount = 0;
                decimal price = 0;
                int productId = int.Parse(dgvProducts.Rows[rowIndex].Cells[0].Value.ToString());
                var inventory = service.GetProductExistence(productId);

                if (rowIndex >= 0)
                {
                    amount = Convert.ToDecimal(dataRow.Cells["Quantity"].Value);
                    price = Convert.ToDecimal(dataRow.Cells["Price"].Value);

                    if (inventory >= amount)
                    {
                        var SubTotalRow = amount * price;
                        dataRow.Cells["SubTotalItem"].Value = SubTotalRow;
                    }
                    else
                    {
                        MessageBox.Show($"No hay suficiente cantidad de este producto en existencia", "Notificacion", MessageBoxButtons.OK);
                        dataRow.Cells["Quantity"].Value = 0;
                        return;
                    }
                }
                foreach (Product p in temporaryProductList)
                {
                    if (productId == p.Id)
                    {
                        p.SubTotal = Convert.ToInt32(amount);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Product product = new Product();
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var rowIndex = dgvProducts.Rows[e.RowIndex].Index;
                    var cellIndex = dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex;
                    int productId = int.Parse(dgvProducts.Rows[rowIndex].Cells[0].Value.ToString());
                    DialogResult result;
                    if (rowIndex >= 0)
                    {
                        if (cellIndex == 5)
                        {
                            result = MessageBox.Show($"ESTA SEGURO QUE DESEA ELIMINAR " +
                                                         $"ESTE PRODUCTO? \n     PARA ELIMNAR PRESIONAR ACEPTAR",
                                                         "Notificacion", MessageBoxButtons.OKCancel);

                            foreach (var p in temporaryProductList)
                            {
                                if (p.Id == productId)
                                {
                                    product = p;
                                }
                            }
                            if (result == DialogResult.OK)
                            {
                                temporaryProductList.Remove(product);
                            }
                        }
                    }
                }
                LoaddtvProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            if (temporaryProductList.Count > 0 && txtName.Text != "" && txtAmountPaid.Text != "")
            {
                SaveSale();
            }
            else if (temporaryProductList.Count <= 0)
            {
                MessageBox.Show($"SELECCIONE PRODUCTOS A COMPRAR", "Notificacion", MessageBoxButtons.OK);
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show($"SELECCIONE UN CLIENTE", "Notificacion", MessageBoxButtons.OK);
            }
            else if (txtAmountPaid.Text == "")
            {
                MessageBox.Show($"INTRODUZCA EL MONTO A CANCELAR", "Notificacion", MessageBoxButtons.OK);
            }
        }


        private void SaveSale()
        {
            try
            {
                Sale sale;

                //Guarda los Datos generales de la venta

                CaptureIdClient();
                SaleService service = new SaleService();
                sale = new Sale()
                {
                    IdClient = this.ClientId,
                    InVoice = txtInVoice.Text,
                    Comment = txtComent.Text,
                    SaleDate = dtpSaleDate.Value,
                    PuerchaseType = CapturePaymentStatus(),
                    PaymentStatus = CapturePaymentStatus(),

                };
                var result = service.SaveSale(sale);
                var salelist = service.GetSale();
                var saleId = (from s in salelist select s.Id).Max();
                this.SaleId = saleId;

                SaveReceivable();
                SaveSaleDetail();

                MessageBox.Show($"FACTURA GUARDADA CON EXITO", "Notificacion", MessageBoxButtons.OK);
                SaleFormLock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void SaveSaleDetail()
        {
            SaleDetailService service = new SaleDetailService();
            foreach (Product p in temporaryProductList)
            {
                SaleDetail saledatail = new SaleDetail()
                {
                    ProductId = p.Id,
                    Quantity = p.SubTotal,
                    SaleId = this.SaleId
                };
                var result = service.SaveSaleDetail(saledatail);
            }
        }

        private void SaveReceivable()
        {
            
            ReceivableService service = new ReceivableService();
            Receivable receivable = new Receivable()
            {
                SaleId = this.SaleId,
                PaidAmount = Convert.ToDecimal(txtAmountPaid.Text),
                TotalAmount = Convert.ToDecimal(txtRemainingPay.Text)
            };

            var result = service.SaveReceivable(receivable);

        }

        private void SaleFormLock()
        {
            txtComent.Enabled = false;
            txtName.Enabled = false;
            txtCustomerDocument.Enabled = false;
            txtCustomerphone.Enabled = false;
            dtpSaleDate.Enabled = false;
            dgvProducts.Enabled = false;
            txtAmountPaid.Enabled = false;
            btAddProduct.Visible = false;
            btbVerification.Visible = false;
            btnAddClient.Visible = false;
            btnCostCalculation.Visible = false;
            btnGenerateInvoice.Visible = false;
            btnClouse.Visible = true;
        }
        private void CaptureIdClient()
        {
            ClientService service = new ClientService();

            string CustomerDocument = txtCustomerDocument.Text;

            var client = service.GetClientByDocumentIdentity(CustomerDocument);

            this.ClientId = client.Id;

        }

        private bool CapturePaymentStatus()
        {
            bool PaymentStatus;
            var status = Convert.ToDecimal(txtRemainingPay.Text);

            if(status > 0)
            {
                PaymentStatus = true;                
            }
            else
            {
                PaymentStatus=false;
            }


            return PaymentStatus;
        }

        private void btnClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Cantidad ingresa es incorreta \nRecuerde solo ingresar numeros sin decimales ni letras", "Notificacion", MessageBoxButtons.OK);
        }

        private void cbRiforCi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string r = cbRiforCi.SelectedItem.ToString();
                if (r == "Rif")
                {
                    txtRiforCi.Text = "J-";
                }
                else if (r == "C.I")
                {
                    txtRiforCi.Text = "V-";
                }
                this.CustomerCliente = txtRiforCi.Text;
                txtCustomerDocument.ReadOnly = false;
                txtCustomerDocument.Enabled = true;
                txtRiforCi.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

       
        private void CalculoDeCostoFinal()
        {
            try
            {
                if (txtAmountPaid.Focused || txtAmountPaid.Text != "")
                {
                    decimal payment = 0;
                    decimal txtRemPay = 0;

                    bool result = decimal.TryParse(txtAmountPaid.Text.ToString(), out payment); //verificar                    

                    if (result)
                    {
                        txtRemPay = this.Total - payment;
                        txtRemainingPay.Text = txtRemPay.ToString();
                    }
                    else if (txtAmountPaid.Text.ToString() == "")
                    {
                        payment = 0;
                        txtAmountPaid.Text = "0";
                        txtRemPay = this.Total - payment;
                        txtRemainingPay.Text = txtRemPay.ToString();
                    }
                    else
                    {
                        MessageBox.Show($"Cantidad ingresa es incorreta \nRecuerde solo ingresar numeros " +
                            $"sin letras ni caracteres especiales", "Notificacion", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void txtAmountPaid_MouseLeave(object sender, EventArgs e)
        {
            if (txtAmountPaid.Focused) { CalculoDeCostoFinal(); }
        }

       
    }
}
//MessageBox.Show($"Cliente no registrado", "Notificacion", MessageBoxButtons.OK);