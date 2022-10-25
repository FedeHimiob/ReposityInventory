namespace SistemaDeInventario
{
    partial class SaleWF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpGeneralInfo = new System.Windows.Forms.GroupBox();
            this.txtCustomerDocument = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRiforCi = new System.Windows.Forms.TextBox();
            this.cbRiforCi = new System.Windows.Forms.ComboBox();
            this.btbVerification = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtCustomerphone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInVoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRemainingPay = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.btnCostCalculation = new System.Windows.Forms.Button();
            this.btnClouse = new System.Windows.Forms.Button();
            this.gpGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpGeneralInfo
            // 
            this.gpGeneralInfo.Controls.Add(this.txtCustomerDocument);
            this.gpGeneralInfo.Controls.Add(this.txtName);
            this.gpGeneralInfo.Controls.Add(this.txtRiforCi);
            this.gpGeneralInfo.Controls.Add(this.cbRiforCi);
            this.gpGeneralInfo.Controls.Add(this.btbVerification);
            this.gpGeneralInfo.Controls.Add(this.btnAddClient);
            this.gpGeneralInfo.Controls.Add(this.txtCustomerphone);
            this.gpGeneralInfo.Controls.Add(this.Phone);
            this.gpGeneralInfo.Controls.Add(this.dtpSaleDate);
            this.gpGeneralInfo.Controls.Add(this.label11);
            this.gpGeneralInfo.Controls.Add(this.txtComent);
            this.gpGeneralInfo.Controls.Add(this.label2);
            this.gpGeneralInfo.Controls.Add(this.label10);
            this.gpGeneralInfo.Controls.Add(this.label9);
            this.gpGeneralInfo.Controls.Add(this.txtInVoice);
            this.gpGeneralInfo.Controls.Add(this.label1);
            this.gpGeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpGeneralInfo.ForeColor = System.Drawing.Color.White;
            this.gpGeneralInfo.Location = new System.Drawing.Point(12, 12);
            this.gpGeneralInfo.Name = "gpGeneralInfo";
            this.gpGeneralInfo.Size = new System.Drawing.Size(1060, 154);
            this.gpGeneralInfo.TabIndex = 0;
            this.gpGeneralInfo.TabStop = false;
            this.gpGeneralInfo.Text = "Informacion General";
            // 
            // txtCustomerDocument
            // 
            this.txtCustomerDocument.Enabled = false;
            this.txtCustomerDocument.Location = new System.Drawing.Point(615, 18);
            this.txtCustomerDocument.Name = "txtCustomerDocument";
            this.txtCustomerDocument.Size = new System.Drawing.Size(118, 23);
            this.txtCustomerDocument.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(533, 48);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtRiforCi
            // 
            this.txtRiforCi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtRiforCi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRiforCi.Enabled = false;
            this.txtRiforCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiforCi.ForeColor = System.Drawing.Color.White;
            this.txtRiforCi.Location = new System.Drawing.Point(595, 19);
            this.txtRiforCi.Multiline = true;
            this.txtRiforCi.Name = "txtRiforCi";
            this.txtRiforCi.Size = new System.Drawing.Size(34, 23);
            this.txtRiforCi.TabIndex = 12;
            // 
            // cbRiforCi
            // 
            this.cbRiforCi.FormattingEnabled = true;
            this.cbRiforCi.Items.AddRange(new object[] {
            "Rif",
            "C.I"});
            this.cbRiforCi.Location = new System.Drawing.Point(533, 17);
            this.cbRiforCi.Name = "cbRiforCi";
            this.cbRiforCi.Size = new System.Drawing.Size(37, 24);
            this.cbRiforCi.TabIndex = 11;
            this.cbRiforCi.SelectionChangeCommitted += new System.EventHandler(this.cbRiforCi_SelectionChangeCommitted);
            // 
            // btbVerification
            // 
            this.btbVerification.ForeColor = System.Drawing.Color.Black;
            this.btbVerification.Location = new System.Drawing.Point(840, 64);
            this.btbVerification.Name = "btbVerification";
            this.btbVerification.Size = new System.Drawing.Size(146, 29);
            this.btbVerification.TabIndex = 10;
            this.btbVerification.Text = "Verificacion CLiente";
            this.btbVerification.UseVisualStyleBackColor = true;
            this.btbVerification.Click += new System.EventHandler(this.btbVerification_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.ForeColor = System.Drawing.Color.Black;
            this.btnAddClient.Location = new System.Drawing.Point(840, 25);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(146, 29);
            this.btnAddClient.TabIndex = 9;
            this.btnAddClient.Text = "Agregar Cliente";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtCustomerphone
            // 
            this.txtCustomerphone.Enabled = false;
            this.txtCustomerphone.Location = new System.Drawing.Point(533, 77);
            this.txtCustomerphone.Name = "txtCustomerphone";
            this.txtCustomerphone.ReadOnly = true;
            this.txtCustomerphone.Size = new System.Drawing.Size(200, 23);
            this.txtCustomerphone.TabIndex = 8;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(442, 80);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(64, 17);
            this.Phone.TabIndex = 7;
            this.Phone.Text = "Telefono";
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Location = new System.Drawing.Point(533, 106);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(265, 23);
            this.dtpSaleDate.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(419, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Fecha de Venta";
            // 
            // txtComent
            // 
            this.txtComent.Location = new System.Drawing.Point(31, 86);
            this.txtComent.Multiline = true;
            this.txtComent.Name = "txtComent";
            this.txtComent.Size = new System.Drawing.Size(320, 62);
            this.txtComent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comentario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Rif/CI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre";
            // 
            // txtInVoice
            // 
            this.txtInVoice.Enabled = false;
            this.txtInVoice.Location = new System.Drawing.Point(156, 31);
            this.txtInVoice.Name = "txtInVoice";
            this.txtInVoice.ReadOnly = true;
            this.txtInVoice.Size = new System.Drawing.Size(216, 23);
            this.txtInVoice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Factura";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(194, 120);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(155, 23);
            this.txtAmountPaid.TabIndex = 8;
            this.txtAmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountPaid_KeyPress);
            this.txtAmountPaid.MouseLeave += new System.EventHandler(this.txtAmountPaid_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto Pagado";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.NameProduct,
            this.Price,
            this.Quantity,
            this.SubTotalItem,
            this.Delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.Location = new System.Drawing.Point(25, 236);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(611, 304);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            this.dgvProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEditAmountInGrid);
            this.dgvProducts.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProducts_DataError);
            // 
            // IdProduct
            // 
            this.IdProduct.DataPropertyName = "Id";
            this.IdProduct.HeaderText = "id";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.Visible = false;
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameProduct.DataPropertyName = "Name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.NameProduct.HeaderText = "Nombre";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.DefaultCellStyle = dataGridViewCellStyle2;
            this.Price.HeaderText = "Precio Unitario";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "SubTotal";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            // 
            // SubTotalItem
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalItem.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubTotalItem.HeaderText = "Subtotal";
            this.SubTotalItem.Name = "SubTotalItem";
            this.SubTotalItem.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Name = "Delete";
            // 
            // btAddProduct
            // 
            this.btAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProduct.Location = new System.Drawing.Point(249, 188);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(135, 29);
            this.btAddProduct.TabIndex = 2;
            this.btAddProduct.Text = "Añadir Producto";
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAmountPaid);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtRemainingPay);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtIVA);
            this.groupBox2.Controls.Add(this.txtSubTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(695, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Montos";
            // 
            // txtRemainingPay
            // 
            this.txtRemainingPay.Enabled = false;
            this.txtRemainingPay.Location = new System.Drawing.Point(194, 149);
            this.txtRemainingPay.Name = "txtRemainingPay";
            this.txtRemainingPay.ReadOnly = true;
            this.txtRemainingPay.Size = new System.Drawing.Size(155, 23);
            this.txtRemainingPay.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(194, 91);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(155, 23);
            this.txtTotal.TabIndex = 6;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(194, 62);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(155, 23);
            this.txtIVA.TabIndex = 5;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(194, 33);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(155, 23);
            this.txtSubTotal.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Monto Restante Por Pagar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Iva (15%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "SubTotal";
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInvoice.Location = new System.Drawing.Point(463, 558);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(219, 36);
            this.btnGenerateInvoice.TabIndex = 4;
            this.btnGenerateInvoice.Text = "Generar Factura";
            this.btnGenerateInvoice.UseVisualStyleBackColor = true;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // btnCostCalculation
            // 
            this.btnCostCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCostCalculation.Location = new System.Drawing.Point(794, 188);
            this.btnCostCalculation.Name = "btnCostCalculation";
            this.btnCostCalculation.Size = new System.Drawing.Size(151, 29);
            this.btnCostCalculation.TabIndex = 5;
            this.btnCostCalculation.Text = "Calculo de Costos";
            this.btnCostCalculation.UseVisualStyleBackColor = true;
            this.btnCostCalculation.Click += new System.EventHandler(this.btnCostCalculation_Click);
            // 
            // btnClouse
            // 
            this.btnClouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClouse.Location = new System.Drawing.Point(831, 534);
            this.btnClouse.Name = "btnClouse";
            this.btnClouse.Size = new System.Drawing.Size(135, 36);
            this.btnClouse.TabIndex = 6;
            this.btnClouse.Text = "SALIR";
            this.btnClouse.UseVisualStyleBackColor = true;
            this.btnClouse.Visible = false;
            this.btnClouse.Click += new System.EventHandler(this.btnClouse_Click);
            // 
            // SaleWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1084, 615);
            this.Controls.Add(this.btnClouse);
            this.Controls.Add(this.btnCostCalculation);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btAddProduct);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.gpGeneralInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleWF";
            this.gpGeneralInfo.ResumeLayout(false);
            this.gpGeneralInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpGeneralInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInVoice;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRemainingPay;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.TextBox txtCustomerDocument;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCostCalculation;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtCustomerphone;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button btbVerification;
        private System.Windows.Forms.Button btnClouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalItem;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ComboBox cbRiforCi;
        private System.Windows.Forms.TextBox txtRiforCi;
    }
}