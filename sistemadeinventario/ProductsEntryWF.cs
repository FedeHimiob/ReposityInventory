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
    public partial class ProductsEntryWF : Form
    {
        public ProductsEntryWF()
        {
            InitializeComponent();
            dgProductsEntry.AutoGenerateColumns = false;
            LoadProductsEntry();
        }
        private void LoadProductsEntry()
        {
            
            ProductsEntryService service = new ProductsEntryService();        
            dgProductsEntry.DataSource = service.GetProductsEntry();
            dgProductsEntry.Refresh();

           /* int productId;
            ProductsEntryService service = new ProductsEntryService();
            //Products p = new Products();
            //productId = p.gv;
            dgProductsEntry.DataSource = service.GetProductsEntryByProductId(productId);
            dgProductsEntry.Refresh();*/
        }
    }
}
