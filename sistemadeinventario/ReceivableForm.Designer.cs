namespace SistemaDeInventario
{
    partial class ReceivableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgRecievable = new System.Windows.Forms.DataGridView();
            this.lblReceivable = new System.Windows.Forms.Label();
            this.IdReceivable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbonaroCancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecievable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRecievable
            // 
            this.dgRecievable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecievable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReceivable,
            this.IdSale,
            this.IdCliente,
            this.Invoice,
            this.SaleDate,
            this.NameClient,
            this.MontoTotal,
            this.PaidAmount,
            this.TotalAmount,
            this.AbonaroCancelar});
            this.dgRecievable.Location = new System.Drawing.Point(80, 175);
            this.dgRecievable.Name = "dgRecievable";
            this.dgRecievable.Size = new System.Drawing.Size(895, 306);
            this.dgRecievable.TabIndex = 0;
            this.dgRecievable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRecievable_CellContentClick);
            // 
            // lblReceivable
            // 
            this.lblReceivable.AutoSize = true;
            this.lblReceivable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivable.ForeColor = System.Drawing.Color.White;
            this.lblReceivable.Location = new System.Drawing.Point(335, 64);
            this.lblReceivable.Name = "lblReceivable";
            this.lblReceivable.Size = new System.Drawing.Size(315, 39);
            this.lblReceivable.TabIndex = 1;
            this.lblReceivable.Text = "Cuentas por Cobrar";
            // 
            // IdReceivable
            // 
            this.IdReceivable.DataPropertyName = "IdReceivable";
            this.IdReceivable.HeaderText = "IdReceivable";
            this.IdReceivable.Name = "IdReceivable";
            this.IdReceivable.Visible = false;
            // 
            // IdSale
            // 
            this.IdSale.DataPropertyName = "IdSale";
            this.IdSale.HeaderText = "IdSale";
            this.IdSale.Name = "IdSale";
            this.IdSale.Visible = false;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdClient";
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Visible = false;
            // 
            // Invoice
            // 
            this.Invoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Invoice.DataPropertyName = "InVoice";
            this.Invoice.HeaderText = "Codigo Factura";
            this.Invoice.Name = "Invoice";
            // 
            // SaleDate
            // 
            this.SaleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "Fecha ";
            this.SaleDate.Name = "SaleDate";
            // 
            // NameClient
            // 
            this.NameClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameClient.DataPropertyName = "Name";
            this.NameClient.HeaderText = "Nombre del Cliente";
            this.NameClient.Name = "NameClient";
            // 
            // MontoTotal
            // 
            this.MontoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MontoTotal.DataPropertyName = "MontoTotal";
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // PaidAmount
            // 
            this.PaidAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaidAmount.DataPropertyName = "PaidAmount";
            this.PaidAmount.HeaderText = "Monto Pagado";
            this.PaidAmount.Name = "PaidAmount";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Restante por pagar";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // AbonaroCancelar
            // 
            this.AbonaroCancelar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AbonaroCancelar.HeaderText = "Obonar/Cancelar";
            this.AbonaroCancelar.Name = "AbonaroCancelar";
            this.AbonaroCancelar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AbonaroCancelar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ReceivableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1068, 576);
            this.Controls.Add(this.lblReceivable);
            this.Controls.Add(this.dgRecievable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceivableForm";
            this.Text = "ReceivableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgRecievable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRecievable;
        private System.Windows.Forms.Label lblReceivable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReceivable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn AbonaroCancelar;
    }
}