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
    public partial class SalesMade : Form
    {
        public SalesMade()
        {
            InitializeComponent();
            dgSalesMade.AutoGenerateColumns = false;
            LoadSalesMade();
        }

        private void LoadSalesMade()
        {
            SaleService service = new SaleService();
            dgSalesMade.DataSource = service.GetSalesMade();
            dgSalesMade.Refresh();
        }

        private void dgSalesMade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SaleService Service = new SaleService();
                var rowIndex = dgSalesMade.Rows[e.RowIndex].Index;
                var cellIndex = dgSalesMade.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex;
                int saleId = int.Parse(dgSalesMade.Rows[rowIndex].Cells[0].Value.ToString());

                if (rowIndex >= 0)
                {
                    if (cellIndex == 6)
                    {
                        SaleDetailForm form = new SaleDetailForm();

                        form.LoadSale += LoadSalesMade;
                        form.IdInvoice = saleId;
                        form.ShowDialog();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
