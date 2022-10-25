using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventario
{
    public partial class NewMainWindow : Form
    {
        public NewMainWindow()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void bntMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new ProductsWF());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new Inventory());           
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PSubSaleMenu);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pReportSubMenu);
        }       

        private void AbrirFromHijo(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }        

        private void btnSalesMade_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new SalesMade());
        }
        private void CustomizeDesing()
        {
            pReportSubMenu.Visible = false;
            PSubSaleMenu.Visible =false;
        }
        private void HideSubMenu()
        {
            if(pReportSubMenu.Visible == true) { pReportSubMenu.Visible = false; }
            if (PSubSaleMenu.Visible == true) { PSubSaleMenu.Visible = false; }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false) { HideSubMenu(); subMenu.Visible = true; }
            else { subMenu.Visible = false; }
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new SaleWF());
            HideSubMenu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
        }

        private void btnReceivable_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new ReceivableForm());
        }
    }
}
