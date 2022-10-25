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
using static Data.EnumInv.EnumInv;


namespace SistemaDeInventario
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            dgInventory.AutoGenerateColumns = false;
            LoadProductsEntry();
        }
        private void LoadProductsEntry()
        {
            try
            {
                ProductsEntryService service = new ProductsEntryService();
                dgInventory.DataSource = service.GetTotalInventory();
                dgInventory.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void dgInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            { 
                ProductService service = new ProductService();
                var rowIndex = dgInventory.Rows[e.RowIndex].Index;
                var cellIndex = dgInventory.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex;
                int productId = int.Parse(dgInventory.Rows[rowIndex].Cells[0].Value.ToString());
                int result;

                    if (rowIndex >= 0)
                    {
                        Product product = new Product();
                        product = service.GetProductById(productId);

                        if (cellIndex == 5) //New Entry
                        {
                            NewEntryOrExit form = new NewEntryOrExit();
                            form.ProductId = productId;
                            form.LoadEntry += LoadProductsEntry;
                            form.Operation = OperationEntryOrExit.Entry;
                            form.IsEntry = true;
                            form.Load_ProductName();
                            form.ShowDialog();
                        }
                        if (cellIndex == 6) //New Exit
                        {
                            NewEntryOrExit form = new NewEntryOrExit();
                            form.ProductId = productId;
                            form.LoadEntry += LoadProductsEntry;
                            form.Operation = OperationEntryOrExit.Exit;
                            form.IsEntry = false;
                            form.Load_ProductName();
                            form.ShowDialog();
                        }
                        if (cellIndex == 7) //Historical
                        {
                            HistoricalProducts form = new HistoricalProducts();
                            form.Id = productId;
                            form.LoadProductsEntrys();
                            form.Load_ProductName();
                            form.ShowDialog();
                        }
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
