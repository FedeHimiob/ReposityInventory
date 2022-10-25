namespace SistemaDeInventario
{
    partial class HistoricalProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgHistoricalProducts = new System.Windows.Forms.DataGridView();
            this.lbName = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoricalProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgHistoricalProducts
            // 
            this.dgHistoricalProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistoricalProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTime,
            this.Entry,
            this.Exit,
            this.Stock});
            this.dgHistoricalProducts.Location = new System.Drawing.Point(48, 129);
            this.dgHistoricalProducts.Name = "dgHistoricalProducts";
            this.dgHistoricalProducts.Size = new System.Drawing.Size(479, 180);
            this.dgHistoricalProducts.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(250, 82);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateTime.DataPropertyName = "EntryDate";
            this.DateTime.HeaderText = "Fecha de Transaccion";
            this.DateTime.Name = "DateTime";
            // 
            // Entry
            // 
            this.Entry.DataPropertyName = "Entrada";
            this.Entry.HeaderText = "Entrada";
            this.Entry.Name = "Entry";
            // 
            // Exit
            // 
            this.Exit.DataPropertyName = "Salida";
            this.Exit.HeaderText = "Salida";
            this.Exit.Name = "Exit";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // HistoricalProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.dgHistoricalProducts);
            this.Controls.Add(this.label1);
            this.Name = "HistoricalProducts";
            this.Text = "HistoricalProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoricalProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgHistoricalProducts;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}