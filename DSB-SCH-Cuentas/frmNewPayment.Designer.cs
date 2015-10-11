namespace Accounts
{
    partial class frmNewPayment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkCreditCard = new System.Windows.Forms.CheckBox();
            this.pnlCreditCard = new System.Windows.Forms.Panel();
            this.duesUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtConcept = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlCreditCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre tarjeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Concepto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Importe:";
            // 
            // chkCreditCard
            // 
            this.chkCreditCard.AutoSize = true;
            this.chkCreditCard.Location = new System.Drawing.Point(12, 12);
            this.chkCreditCard.Name = "chkCreditCard";
            this.chkCreditCard.Size = new System.Drawing.Size(76, 17);
            this.chkCreditCard.TabIndex = 4;
            this.chkCreditCard.Text = "Es tarjeta?";
            this.chkCreditCard.UseVisualStyleBackColor = true;
            this.chkCreditCard.CheckedChanged += new System.EventHandler(this.chkCreditCard_CheckedChanged);
            // 
            // pnlCreditCard
            // 
            this.pnlCreditCard.Controls.Add(this.duesUpDown);
            this.pnlCreditCard.Controls.Add(this.label4);
            this.pnlCreditCard.Controls.Add(this.txtCardName);
            this.pnlCreditCard.Controls.Add(this.label1);
            this.pnlCreditCard.Location = new System.Drawing.Point(12, 35);
            this.pnlCreditCard.Name = "pnlCreditCard";
            this.pnlCreditCard.Size = new System.Drawing.Size(304, 69);
            this.pnlCreditCard.TabIndex = 5;
            // 
            // duesUpDown
            // 
            this.duesUpDown.Location = new System.Drawing.Point(94, 37);
            this.duesUpDown.Name = "duesUpDown";
            this.duesUpDown.Size = new System.Drawing.Size(194, 20);
            this.duesUpDown.TabIndex = 4;
            this.duesUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "# cuotas:";
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(94, 8);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(194, 20);
            this.txtCardName.TabIndex = 1;
            // 
            // txtConcept
            // 
            this.txtConcept.Location = new System.Drawing.Point(106, 110);
            this.txtConcept.Name = "txtConcept";
            this.txtConcept.Size = new System.Drawing.Size(194, 20);
            this.txtConcept.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(106, 140);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(194, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(106, 169);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(194, 20);
            this.dtpEntryDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha:";
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(160, 224);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(241, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 267);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtConcept);
            this.Controls.Add(this.pnlCreditCard);
            this.Controls.Add(this.chkCreditCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNewPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "De Sousa - Scheiner Nuevo Pago";
            this.pnlCreditCard.ResumeLayout(false);
            this.pnlCreditCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkCreditCard;
        private System.Windows.Forms.Panel pnlCreditCard;
        private System.Windows.Forms.NumericUpDown duesUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtConcept;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}