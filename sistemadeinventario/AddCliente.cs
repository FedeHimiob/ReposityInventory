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
    public delegate void LoadClientDelegate(string documentIdentity);

    public partial class AddCliente : Form
    {

        public event LoadClientDelegate LoadClient;
        
        public AddCliente()
        {
            InitializeComponent();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ClientService service = new ClientService();

                var resul = (txtRiforCI.Text + txtDocumentIdentity.Text).ToString();
                var clienteExistence = service.GetClientByDocumentIdentity(resul);
                if (clienteExistence == null)
                {
                    Client client = new Client()
                    {
                        Id = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),

                        Name = txtName.Text,

                        DocumentIdentity = resul,

                        Phone = txtPhone.Text
                    };

                    var result = service.SaveClient(client);

                    this.LoadClient(client.DocumentIdentity);

                }
                else
                {
                    MessageBox.Show($"Cliente ya Existe", "Notificacion", MessageBoxButtons.OK);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void cbRiforCi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string r = cbRiforCi.SelectedItem.ToString();
                if (r == "Rif")
                {
                    txtRiforCI.Text = "J-";
                }
                else if (r == "C.I")
                {
                    txtRiforCI.Text = "V-";
                }
                txtDocumentIdentity.ReadOnly = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            
        }

       
    }
}
