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
    public partial class ReceivableForm : Form
    {
        public ReceivableForm()
        {
            InitializeComponent();
            dgRecievable.AutoGenerateColumns = false;
            LoadReceivableMade();
        }
        private void LoadReceivableMade()
        {
            ReceivableService service = new ReceivableService();
            dgRecievable.DataSource = service.GetReceivableMade();
            dgRecievable.Refresh();
        }
        private void dgRecievable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SaleService Service = new SaleService();
                var rowIndex = dgRecievable.Rows[e.RowIndex].Index;
                var cellIndex = dgRecievable.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex;
                int saleId = int.Parse(dgRecievable.Rows[rowIndex].Cells[1].Value.ToString());

                if (rowIndex >= 0)
                {
                    if (cellIndex == 9)
                    {
                        SaleDetailForm form = new SaleDetailForm();

                        form.IdInvoice = saleId;
                        form.ItsReceivable = true;
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
