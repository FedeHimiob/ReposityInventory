namespace SistemaDeInventario
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtbProductEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtbProductoOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewEntry = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NewOutput = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Record = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgInventory
            // 
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.Product,
            this.dgtbProductEntry,
            this.dgtbProductoOutput,
            this.ProductAvailable,
            this.NewEntry,
            this.NewOutput,
            this.Record});
            this.dgInventory.Location = new System.Drawing.Point(74, 109);
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.Size = new System.Drawing.Size(880, 326);
            this.dgInventory.TabIndex = 1;
            this.dgInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventory_CellContentClick);
            // 
            // IdProduct
            // 
            this.IdProduct.DataPropertyName = "Id";
            this.IdProduct.HeaderText = "IdProduct";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.Visible = false;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataPropertyName = "Name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.DefaultCellStyle = dataGridViewCellStyle1;
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            // 
            // dgtbProductEntry
            // 
            this.dgtbProductEntry.DataPropertyName = "CantidadEntrada";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtbProductEntry.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgtbProductEntry.HeaderText = "Entrada";
            this.dgtbProductEntry.Name = "dgtbProductEntry";
            // 
            // dgtbProductoOutput
            // 
            this.dgtbProductoOutput.DataPropertyName = "CantidadSalida";
            this.dgtbProductoOutput.HeaderText = "Salida";
            this.dgtbProductoOutput.Name = "dgtbProductoOutput";
            // 
            // ProductAvailable
            // 
            this.ProductAvailable.DataPropertyName = "CantidadDisponible";
            this.ProductAvailable.HeaderText = "Disponible";
            this.ProductAvailable.Name = "ProductAvailable";
            // 
            // NewEntry
            // 
            this.NewEntry.HeaderText = "Nueva Entrada";
            this.NewEntry.Name = "NewEntry";
            this.NewEntry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NewEntry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NewEntry.Width = 70;
            // 
            // NewOutput
            // 
            this.NewOutput.HeaderText = "Nueva Salida";
            this.NewOutput.Name = "NewOutput";
            this.NewOutput.Width = 70;
            // 
            // Record
            // 
            this.Record.HeaderText = "Historial";
            this.Record.Name = "Record";
            this.Record.Width = 70;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1068, 576);
            this.Controls.Add(this.dgInventory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbProductEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbProductoOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAvailable;
        private System.Windows.Forms.DataGridViewButtonColumn NewEntry;
        private System.Windows.Forms.DataGridViewButtonColumn NewOutput;
        private System.Windows.Forms.DataGridViewButtonColumn Record;
    }
}