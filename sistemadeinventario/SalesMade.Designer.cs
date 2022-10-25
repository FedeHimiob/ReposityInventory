namespace SistemaDeInventario
{
    partial class SalesMade
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
            this.dgSalesMade = new System.Windows.Forms.DataGridView();
            this.IdSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceShow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesMade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSalesMade
            // 
            this.dgSalesMade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalesMade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSale,
            this.IdClient,
            this.InvoiceCode,
            this.ClientName,
            this.Date,
            this.Amount,
            this.InvoiceShow});
            this.dgSalesMade.Location = new System.Drawing.Point(97, 147);
            this.dgSalesMade.Name = "dgSalesMade";
            this.dgSalesMade.Size = new System.Drawing.Size(902, 388);
            this.dgSalesMade.TabIndex = 0;
            this.dgSalesMade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSalesMade_CellContentClick);
            // 
            // IdSale
            // 
            this.IdSale.DataPropertyName = "Id";
            this.IdSale.HeaderText = "id";
            this.IdSale.Name = "IdSale";
            this.IdSale.Visible = false;
            // 
            // IdClient
            // 
            this.IdClient.DataPropertyName = "IdClient";
            this.IdClient.HeaderText = "IdClient";
            this.IdClient.Name = "IdClient";
            this.IdClient.Visible = false;
            // 
            // InvoiceCode
            // 
            this.InvoiceCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceCode.DataPropertyName = "InVoice";
            this.InvoiceCode.HeaderText = "Codigo de Factura";
            this.InvoiceCode.Name = "InvoiceCode";
            this.InvoiceCode.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.DataPropertyName = "Name";
            this.ClientName.HeaderText = "Nombre del Cliente";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "SaleDate";
            this.Date.HeaderText = "Fecha";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Monto";
            this.Amount.HeaderText = "Monto Total";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // InvoiceShow
            // 
            this.InvoiceShow.HeaderText = "Ver detalle";
            this.InvoiceShow.Name = "InvoiceShow";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas Realizadas";
            // 
            // SalesMade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1068, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSalesMade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesMade";
            this.Text = "SalesMade";
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesMade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSalesMade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewButtonColumn InvoiceShow;
    }
}