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
using Data.Servicies;
using static Data.EnumInv.EnumInv;

namespace SistemaDeInventario
{
    public partial class ProductsWF : Form
    {
        
        public ProductsWF()
        {
            InitializeComponent();
            dgProducts.AutoGenerateColumns = false;
            LoadProducts();
        }
       

        private void LoadProducts()
        {
            ProductService service = new ProductService();
            dgProducts.DataSource = service.GetProducts().ToList();
            dgProducts.Refresh();
        }

        private void btNewProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ProductService service = new ProductService();
                NuevoProducto form = new NuevoProducto();
                form.LoadProducts += LoadProducts;
                form.Operation = OperationProducts.Insert;
                form.ShowDialog(this);
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void gvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProductService service = new ProductService();
                var rowIndex = dgProducts.Rows[e.RowIndex].Index;
                var cellIndex = dgProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex;
                int productId = int.Parse(dgProducts.Rows[rowIndex].Cells[0].Value.ToString());

                DialogResult result2;
                int result;

                if (rowIndex >= 0)
                {
                    Product product = new Product();
                    product = service.GetProductById(productId);

                    if (cellIndex == 6)
                    {
                        result2 = MessageBox.Show($"ESTA SEGURO QUE DESEA ELIMINAR " +
                                                    $"ESTE PRODUCTO? \n     PARA ELIMNAR PRESIONAR ACEPTAR",
                                                    "Notificacion", MessageBoxButtons.OKCancel);
                        if(result2 == DialogResult.OK)
                        {
                            result = service.DeleteProduct(productId);
                            LoadProducts();
                        }                        
                    }
                    if (cellIndex == 5)
                    {
                        NuevoProducto form = new NuevoProducto();
                        form.LoadProducts += LoadProducts;
                        form.Operation = OperationProducts.Edit;
                        form.ProductId = productId;
                        form.ShowDialog(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK);
            }

        }

    }
}
