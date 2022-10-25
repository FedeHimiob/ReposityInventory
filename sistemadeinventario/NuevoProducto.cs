using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Entities;
using Data.EnumInv;
using Data.Servicies;

namespace SistemaDeInventario
{
    public delegate void LoadProductDelegate();
    public partial class NuevoProducto : Form
    {
        public event LoadProductDelegate LoadProducts;

        public EnumInv.OperationProducts Operation { get; set; }
        public int ProductId { get; set; }

        public NuevoProducto()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Operation == EnumInv.OperationProducts.Insert)
                {
                    lbTituloForm.Text = "Creacion de Nuevo Producto";
                }
                else
                {
                    lbTituloForm.Text = "Editar Producto";
                    Load_Product();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void Load_Product()
        {
            try
            {
                ProductService service = new ProductService();
                var product = service.GetProductById(ProductId);
                txtId.Text = product.Id.ToString();
                txtName.Text = product.Name;
                txtDescription.Text = product.Description;
                txtPrice.Text = product.Price.ToString();
                cbxActive.Checked = product.IsActive;
                cbCategory.SelectedItem = product.Category;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtDescription.Text != "" && cbCategory.SelectedItem != null && txtPrice.Text != "")
                {
                    ProductService service = new ProductService();

                    Product product = new Product()
                    {
                        Id = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        Category = cbCategory.SelectedItem.ToString(),
                        IsActive = cbxActive.Checked,
                        Price = Convert.ToDecimal(txtPrice.Text)
                    };

                    var result = service.SaveProduct(product);
                    this.LoadProducts();
                    Close();

                }
                else if (txtName.Text == "") { MessageBox.Show("introduzca un nombre de producto", "Notificacion", MessageBoxButtons.OK); }
                else if (cbCategory.SelectedItem == null) { MessageBox.Show("introduzca una categoria de producto", "Notificacion", MessageBoxButtons.OK); }
                else if (txtPrice.Text == "") { MessageBox.Show("introduzca un costo de producto", "Notificacion", MessageBoxButtons.OK); }
                else if (txtDescription.Text == "") { MessageBox.Show("introduzca una descripcion de producto", "Notificacion", MessageBoxButtons.OK); }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        
    }
}
