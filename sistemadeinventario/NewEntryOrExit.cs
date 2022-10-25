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
using Data.Entities;
using Data.EnumInv;


namespace SistemaDeInventario
{
    public delegate void LoadEntryDelegate();

    public partial class NewEntryOrExit : Form
    {
        public event LoadEntryDelegate LoadEntry;
        public EnumInv.OperationEntryOrExit Operation { get; set; }
        public int ProductId { get; set; }
        public bool IsEntry { get; set; }

        public NewEntryOrExit()
        {
            InitializeComponent();
            txtIdProduct.Enabled = false;
        }
       
        public void Load_ProductName()
        {
            try
            {
                ProductService service = new ProductService();
                var product = service.GetProductById(ProductId);
                txtIdProduct.Text = product.Id.ToString();
                lbNameProduct.Text = product.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
           
        }
        private void NewEntryOrExit_Load(object sender, EventArgs e)
        {
            try
            {
                if (Operation == EnumInv.OperationEntryOrExit.Entry)
                {
                    lbNewEntryorExit.Text = "Nuevo Ingreso";
                }
                else
                {
                    lbNewEntryorExit.Text = "Nueva Salida";
                    Load_ProductName();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        
        }


        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                int q;
                bool parse = Int32.TryParse(txtQuantity.Text, out q);
                if (parse)
                {
                    ProductsEntryService service = new ProductsEntryService();
                    ProductsEntry productsEntry = new ProductsEntry()
                    {
                        ProductId = string.IsNullOrEmpty(txtIdProduct.Text) ? 0 : Convert.ToInt32(txtIdProduct.Text),
                        Quantity = Convert.ToInt32(txtQuantity.Text),
                        EntryDate = dateTimePicker1.Value,
                        IsEntry = this.IsEntry

                    };

                    var inventory = service.GetProductExistence(this.ProductId);

                    if (Operation == EnumInv.OperationEntryOrExit.Exit && inventory < Convert.ToInt32(txtQuantity.Text))
                    {
                        MessageBox.Show("No hay suficiente cantidad de este producto ", "Notificacion", MessageBoxButtons.OK);
                        return;
                    }

                    var result = service.SaveProductsEntry(productsEntry);
                    this.LoadEntry();

                    Close();
                }
                else if (txtQuantity.Text == "") { MessageBox.Show("No ah introducido una cantidad \nrecuerde solo introducir numeros enteros ", "Notificacion", MessageBoxButtons.OK); }
                else { MessageBox.Show("valor intrudicido es incorrecto \nrecuerde solo introducir numeros enteros ", "Notificacion", MessageBoxButtons.OK); }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }

        
    
}
