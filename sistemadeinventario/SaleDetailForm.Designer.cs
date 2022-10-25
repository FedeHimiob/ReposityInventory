namespace SistemaDeInventario
{
    partial class SaleDetailForm
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
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.txtComent = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.dgProductList = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemainingPay = new System.Windows.Forms.TextBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.gpGenralInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaleDate = new System.Windows.Forms.TextBox();
            this.Invoice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEstadoDelPago = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.txtAbonarCancelar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpGenralInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comentario";
            // 
            // txtInvoice
            // 
            this.txtInvoice.Enabled = false;
            this.txtInvoice.Location = new System.Drawing.Point(104, 19);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.Size = new System.Drawing.Size(109, 20);
            this.txtInvoice.TabIndex = 1;
            // 
            // txtComent
            // 
            this.txtComent.Enabled = false;
            this.txtComent.Location = new System.Drawing.Point(22, 80);
            this.txtComent.Multiline = true;
            this.txtComent.Name = "txtComent";
            this.txtComent.ReadOnly = true;
            this.txtComent.Size = new System.Drawing.Size(249, 65);
            this.txtComent.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(451, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(143, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtDocument
            // 
            this.txtDocument.Enabled = false;
            this.txtDocument.Location = new System.Drawing.Point(451, 89);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.ReadOnly = true;
            this.txtDocument.Size = new System.Drawing.Size(143, 20);
            this.txtDocument.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(451, 54);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(143, 20);
            this.TxtName.TabIndex = 5;
            // 
            // dgProductList
            // 
            this.dgProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.NameProduct,
            this.Price,
            this.Quantity});
            this.dgProductList.Location = new System.Drawing.Point(60, 209);
            this.dgProductList.Name = "dgProductList";
            this.dgProductList.Size = new System.Drawing.Size(389, 173);
            this.dgProductList.TabIndex = 6;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "Id";
            this.ProductId.HeaderText = "id";
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "Name";
            this.NameProduct.HeaderText = "Nombre";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Precio";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "SubTotal";
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRemainingPay);
            this.groupBox2.Controls.Add(this.txtAmountPaid);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtIva);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Location = new System.Drawing.Point(490, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 161);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de Pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Por Pagar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Pagado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Iva 15%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "SubTotal";
            // 
            // txtRemainingPay
            // 
            this.txtRemainingPay.Enabled = false;
            this.txtRemainingPay.Location = new System.Drawing.Point(104, 127);
            this.txtRemainingPay.Name = "txtRemainingPay";
            this.txtRemainingPay.ReadOnly = true;
            this.txtRemainingPay.Size = new System.Drawing.Size(116, 20);
            this.txtRemainingPay.TabIndex = 4;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Enabled = false;
            this.txtAmountPaid.Location = new System.Drawing.Point(104, 100);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.ReadOnly = true;
            this.txtAmountPaid.Size = new System.Drawing.Size(116, 20);
            this.txtAmountPaid.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(104, 74);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(116, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(104, 47);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(116, 20);
            this.txtIva.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(104, 20);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(116, 20);
            this.txtSubtotal.TabIndex = 0;
            // 
            // gpGenralInfo
            // 
            this.gpGenralInfo.Controls.Add(this.label2);
            this.gpGenralInfo.Controls.Add(this.txtSaleDate);
            this.gpGenralInfo.Controls.Add(this.Invoice);
            this.gpGenralInfo.Controls.Add(this.label5);
            this.gpGenralInfo.Controls.Add(this.label4);
            this.gpGenralInfo.Controls.Add(this.label3);
            this.gpGenralInfo.Controls.Add(this.txtPhone);
            this.gpGenralInfo.Controls.Add(this.txtInvoice);
            this.gpGenralInfo.Controls.Add(this.txtDocument);
            this.gpGenralInfo.Controls.Add(this.txtComent);
            this.gpGenralInfo.Controls.Add(this.TxtName);
            this.gpGenralInfo.Controls.Add(this.label1);
            this.gpGenralInfo.Location = new System.Drawing.Point(60, 12);
            this.gpGenralInfo.Name = "gpGenralInfo";
            this.gpGenralInfo.Size = new System.Drawing.Size(689, 163);
            this.gpGenralInfo.TabIndex = 9;
            this.gpGenralInfo.TabStop = false;
            this.gpGenralInfo.Text = "Informacion general";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha ";
            // 
            // txtSaleDate
            // 
            this.txtSaleDate.Enabled = false;
            this.txtSaleDate.Location = new System.Drawing.Point(360, 19);
            this.txtSaleDate.Name = "txtSaleDate";
            this.txtSaleDate.ReadOnly = true;
            this.txtSaleDate.Size = new System.Drawing.Size(244, 20);
            this.txtSaleDate.TabIndex = 10;
            // 
            // Invoice
            // 
            this.Invoice.AutoSize = true;
            this.Invoice.Location = new System.Drawing.Point(19, 22);
            this.Invoice.Name = "Invoice";
            this.Invoice.Size = new System.Drawing.Size(79, 13);
            this.Invoice.TabIndex = 9;
            this.Invoice.Text = "Codigo Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rif o C.I";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre ";
            // 
            // lbEstadoDelPago
            // 
            this.lbEstadoDelPago.AutoSize = true;
            this.lbEstadoDelPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoDelPago.Location = new System.Drawing.Point(245, 400);
            this.lbEstadoDelPago.Name = "lbEstadoDelPago";
            this.lbEstadoDelPago.Size = new System.Drawing.Size(243, 31);
            this.lbEstadoDelPago.TabIndex = 10;
            this.lbEstadoDelPago.Text = "Estado de Factura ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lista de Productos";
            // 
            // btnAbonar
            // 
            this.btnAbonar.Location = new System.Drawing.Point(490, 349);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(96, 23);
            this.btnAbonar.TabIndex = 14;
            this.btnAbonar.Text = "Abonar/Cancelar";
            this.btnAbonar.UseVisualStyleBackColor = true;
            this.btnAbonar.Visible = false;
            // 
            // txtAbonarCancelar
            // 
            this.txtAbonarCancelar.Location = new System.Drawing.Point(594, 348);
            this.txtAbonarCancelar.Name = "txtAbonarCancelar";
            this.txtAbonarCancelar.ReadOnly = true;
            this.txtAbonarCancelar.Size = new System.Drawing.Size(116, 20);
            this.txtAbonarCancelar.TabIndex = 15;
            this.txtAbonarCancelar.Visible = false;
            // 
            // SaleDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAbonarCancelar);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbEstadoDelPago);
            this.Controls.Add(this.gpGenralInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgProductList);
            this.Name = "SaleDetailForm";
            this.Text = "SaleDetailForm";
            this.Load += new System.EventHandler(this.SaleDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpGenralInfo.ResumeLayout(false);
            this.gpGenralInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.TextBox txtComent;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.DataGridView dgProductList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtRemainingPay;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gpGenralInfo;
        private System.Windows.Forms.Label lbEstadoDelPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Invoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.TextBox txtAbonarCancelar;
    }
}