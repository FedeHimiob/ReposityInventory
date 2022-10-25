using Data.Entities;
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

namespace SistemaDeInventario
{
    public delegate void LoadSaleDelegate();
    public partial class SaleDetailForm : Form
    {
        public event LoadSaleDelegate LoadSale;

        private List<Product> temporaryProductList = new List<Product>();
        public int IdInvoice { get; set; }
        public int IdClient { get; set; }
        public decimal SubTotal { get; set; }
        private const double V = 0.15;
        private double IVA = V;
        public bool ItsReceivable { get; set; }

        public SaleDetailForm()
        {
            InitializeComponent();
            dgProductList.AutoGenerateColumns= false;
        }

        private void ShowSaleDetail()
        {
            try
            {
                SaleService saleService = new SaleService();
                var sale = saleService.GetSaleById(this.IdInvoice);
                if (sale != null)
                {


                    this.IdClient = sale.IdClient;
                    txtInvoice.Text = sale.InVoice;
                    txtComent.Text = sale.Comment;
                    txtSaleDate.Text = sale.SaleDate.ToString();



                    ProductService productService = new ProductService();
                    SaleDetailService saleDetailService = new SaleDetailService();
                    var saleDetail = saleDetailService.GetSaleDetailBySaleId(this.IdInvoice).ToList();
                    for (int i = 0; i < saleDetail.Count; i++)
                    {
                        Product product = new Product();
                        product.Id = saleDetail[i].ProductId;
                        product.SubTotal = saleDetail[i].Quantity;
                        var p = productService.GetProductById(product.Id);
                        product.Name = p.Name;
                        product.Price = p.Price;
                        temporaryProductList.Add(product);
                        decimal result = (product.SubTotal * product.Price);
                        this.SubTotal += result;
                    }
                    dgProductList.DataSource = temporaryProductList;


                    ReceivableService receivableService = new ReceivableService();
                    var receivable = receivableService.GetReceivableSaleId(this.IdInvoice);

                    txtSubtotal.Text = this.SubTotal.ToString();
                    decimal iva = (this.SubTotal * Convert.ToDecimal(IVA));
                    txtIva.Text = iva.ToString();
                    txtTotal.Text = (this.SubTotal + iva).ToString();

                    if (receivable != null)
                    {
                        string paid = receivable.TotalAmount.ToString();
                        if (receivable != null)
                        {
                            txtAmountPaid.Text = receivable.PaidAmount.ToString();
                            txtRemainingPay.Text = paid;
                        }

                        if (paid == "")
                        {
                            lbEstadoDelPago.Text = "Factura Cancelada";
                            lbEstadoDelPago.ForeColor = Color.Green;
                        }
                        else if (Convert.ToDecimal(paid) > 0)
                        {
                            lbEstadoDelPago.Text = "Factura Por Cobrar";
                            lbEstadoDelPago.ForeColor = Color.Red;
                        }
                    }

                    ClientService clientService = new ClientService();
                    var client = clientService.GetClientById(this.IdClient);
                    if (client != null)
                    {
                        TxtName.Text = client.Name;
                        txtPhone.Text = client.Phone;
                        txtDocument.Text = client.DocumentIdentity;
                    }
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); }

        }

        private void SaleDetailForm_Load(object sender, EventArgs e)
        {
            ShowSaleDetail();
            if(ItsReceivable == true)
            {
                txtAbonarCancelar.Visible = true;
                btnAbonar.Visible = true;
            }
        }
    }
}
