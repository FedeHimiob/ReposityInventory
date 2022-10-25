using Data.Entities;
using Data.Models;
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
    public delegate void LoadProductInvoiceDelegate(int[] ProductList);
    public partial class AddProduct : Form
    {
        public event LoadProductInvoiceDelegate LoadInvoiceProducts;

        public SaleWF formList = new SaleWF();
        public List<Product> temporaryProductList1 = new List<Product>();

        public AddProduct()
        {
            InitializeComponent();
            dgProducts.AutoGenerateColumns = false;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsEntryService service = new ProductsEntryService();
                // ProductService service = new ProductService();

                var lst = service.GetTotalInventory().Where(p => p.Name.Contains(txtBuscar.Text));
                dgProducts.DataSource = lst.ToList();
                dgProducts.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK);
            }

        }

        //private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    ProductService service = new ProductService();
        //    var rowIndex = dgProducts.Rows[e.RowIndex].Index;
        //    var cellIndex = dgProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex;
        //    int productId = int.Parse(dgProducts.Rows[rowIndex].Cells[0].Value.ToString());
        //    int result;

        //    if (rowIndex >= 0)
        //    {
        //        Product product = new Product();
        //        product = service.GetProductById(productId);

        //         if (cellIndex == 5) //Select Product
        //         {
        //           temporaryProductList1.Add(product);

        //         }
              
        //    }
        //}

        private void SaveAndClose_Click(object sender, EventArgs e)
        {
            try
            {
                int[] products = new int[dgProducts.RowCount];
                ProductsEntryService service = new ProductsEntryService();
                ProductService serv = new ProductService();

                for (int i = 0; i < dgProducts.RowCount; i++)
                {
                    var row = (DataGridViewRow)dgProducts.Rows[i];

                    if (Convert.ToBoolean(row.Cells["Select"].Value))
                    {
                        var productId = int.Parse(row.Cells[0].Value.ToString());
                        var pinventory = service.GetTotalInventory().Where(p => (p.Id == productId)).Select(p => p.CantidadDisponible).FirstOrDefault();

                        if (pinventory > 0)
                        {
                            products[i] = productId;
                        }
                        else
                        {
                            var prod = serv.GetProductById(productId).Name.ToString();

                            MessageBox.Show($"No hay suficiente cantidad del siguiente producto: \n{prod}", "Notificacion", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
                this.LoadInvoiceProducts(products);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
