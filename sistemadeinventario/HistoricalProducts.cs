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
    public partial class HistoricalProducts : Form
    {
        public int Id { get; set; }

        public HistoricalProducts()
        {
            InitializeComponent();
            dgHistoricalProducts.AutoGenerateColumns = false;
        }
        public void LoadProductsEntrys()
        {
            try
            {
                ProductsEntryService service = new ProductsEntryService();
                dgHistoricalProducts.DataSource = service.GetHistoricalProductEntries(this.Id);
                dgHistoricalProducts.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
           
        }
        public void Load_ProductName()
        {
            try
            {
                ProductService service = new ProductService();
                var product = service.GetProductById(this.Id);
                lbName.Text = product.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
