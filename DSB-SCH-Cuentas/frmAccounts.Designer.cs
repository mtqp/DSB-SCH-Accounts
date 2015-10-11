using enfoke.Windows.Forms;
namespace Accounts
{
    partial class frmAccounts
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
            this.slv = new enfoke.Windows.Forms.SuperListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.monthUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToPay = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // slv
            // 
            this.slv.Alignment = System.Windows.Forms.ListViewAlignment.Top;
            this.slv.AllowColumnReorder = false;
            this.slv.AllowSort = true;
            this.slv.CanEdit = true;
            this.slv.CheckBoxes = false;
            this.slv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
            this.slv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slv.Extender = null;
            this.slv.GridLines = false;
            this.slv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Clickable;
            this.slv.IsLayoutBound = false;
            this.slv.ListViewItemSorter = null;
            this.slv.Location = new System.Drawing.Point(0, 0);
            this.slv.MaxRows = -1;
            this.slv.MultiSelect = false;
            this.slv.Name = "slv";
            this.slv.Scrollable = true;
            this.slv.SelectedIndex = -1;
            this.slv.SelectedItem = null;
            this.slv.Size = new System.Drawing.Size(747, 312);
            this.slv.SmallImageList = null;
            this.slv.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.slv.SymbolType = enfoke.Windows.Forms.SymbolType.SymbolV;
            this.slv.TabIndex = 0;
            this.slv.TopItem = null;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarjeta";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Concepto";
            this.columnHeader4.Width = 297;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cuota";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Monto";
            this.columnHeader3.Width = 501;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.slv);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 312);
            this.panel1.TabIndex = 1;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(74, 14);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(138, 21);
            this.cmbPaymentMethod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mes:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(684, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // monthUpDown
            // 
            this.monthUpDown.Location = new System.Drawing.Point(284, 15);
            this.monthUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthUpDown.Name = "monthUpDown";
            this.monthUpDown.Size = new System.Drawing.Size(120, 20);
            this.monthUpDown.TabIndex = 6;
            this.monthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(460, 14);
            this.yearUpDown.Maximum = new decimal(new int[] {
            2035,
            0,
            0,
            0});
            this.yearUpDown.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(120, 20);
            this.yearUpDown.TabIndex = 7;
            this.yearUpDown.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(522, 417);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Cargar";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(437, 417);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 9;
            this.btnDetail.Text = "Detalle";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tarjeta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Año:";
            // 
            // lblToPay
            // 
            this.lblToPay.AutoSize = true;
            this.lblToPay.Location = new System.Drawing.Point(13, 417);
            this.lblToPay.Name = "lblToPay";
            this.lblToPay.Size = new System.Drawing.Size(82, 13);
            this.lblToPay.TabIndex = 12;
            this.lblToPay.Text = "Total a pagar: 0";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(603, 417);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 452);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblToPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.monthUpDown);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.panel1);
            this.Name = "frmAccounts";
            this.Text = "De Sousa - Scheiner Cuentas";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        SuperListView slv;

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown monthUpDown;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblToPay;
        private System.Windows.Forms.Button btnDelete;
    }
}

