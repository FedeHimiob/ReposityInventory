namespace SistemaDeInventario
{
    partial class AddCliente
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
            this.lbNewClient = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDocumentIdentity = new System.Windows.Forms.TextBox();
            this.txtRiforCI = new System.Windows.Forms.TextBox();
            this.cbRiforCi = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNewClient
            // 
            this.lbNewClient.AutoSize = true;
            this.lbNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewClient.Location = new System.Drawing.Point(36, 29);
            this.lbNewClient.Name = "lbNewClient";
            this.lbNewClient.Size = new System.Drawing.Size(185, 31);
            this.lbNewClient.TabIndex = 0;
            this.lbNewClient.Text = "Nuevo Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDocumentIdentity);
            this.groupBox1.Controls.Add(this.txtRiforCI);
            this.groupBox1.Controls.Add(this.cbRiforCi);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 221);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del CLiente";
            // 
            // txtDocumentIdentity
            // 
            this.txtDocumentIdentity.Location = new System.Drawing.Point(216, 84);
            this.txtDocumentIdentity.Multiline = true;
            this.txtDocumentIdentity.Name = "txtDocumentIdentity";
            this.txtDocumentIdentity.ReadOnly = true;
            this.txtDocumentIdentity.Size = new System.Drawing.Size(140, 23);
            this.txtDocumentIdentity.TabIndex = 8;
            // 
            // txtRiforCI
            // 
            this.txtRiforCI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRiforCI.Location = new System.Drawing.Point(198, 87);
            this.txtRiforCI.Multiline = true;
            this.txtRiforCI.Name = "txtRiforCI";
            this.txtRiforCI.ReadOnly = true;
            this.txtRiforCI.Size = new System.Drawing.Size(34, 23);
            this.txtRiforCI.TabIndex = 19;
            // 
            // cbRiforCi
            // 
            this.cbRiforCi.FormattingEnabled = true;
            this.cbRiforCi.Items.AddRange(new object[] {
            "Rif",
            "C.I"});
            this.cbRiforCi.Location = new System.Drawing.Point(137, 84);
            this.cbRiforCi.Name = "cbRiforCi";
            this.cbRiforCi.Size = new System.Drawing.Size(42, 23);
            this.cbRiforCi.TabIndex = 11;
            this.cbRiforCi.SelectionChangeCommitted += new System.EventHandler(this.cbRiforCi_SelectionChangeCommitted);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(137, 120);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(219, 23);
            this.txtPhone.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 13);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(113, 21);
            this.txtId.TabIndex = 17;
            this.txtId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rif/CI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre y Apellido";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 46);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 23);
            this.txtName.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(436, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 385);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNewClient);
            this.Name = "AddCliente";
            this.Text = "AddCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNewClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumentIdentity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbRiforCi;
        private System.Windows.Forms.TextBox txtRiforCI;
    }
}