using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using enfoke.OOPS;

namespace Accounts
{
    public partial class frmNewPayment : Form
    {
        protected Payment payment;

        public frmNewPayment()
        {
            payment = null;
            InitializeComponent();
            this.chkCreditCard.Checked = true;
            dtpEntryDate.Value = DateTime.Now;
            this.OrderTabIndexes();
        }

        public Payment Payment { get { return payment; } }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                CreatePayment();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CreatePayment()
        {
            double amount = ParseAmount();
            string concept = txtConcept.Text;
            DateTime entryDate = dtpEntryDate.Value;

            chkCreditCard.Checked.IfTrue(() => 
            {
                string cardName = txtCardName.Text;
                int dues = (int)duesUpDown.Value;

                payment = new Payment(new CreditCard(cardName), concept, entryDate, dues, amount);
            })
            .IfFalse(() => 
            {
                payment = new Payment(new Cash(), concept, entryDate, amount);
            });
        }

        private double ParseAmount()
        {
            double amount;
            if (!double.TryParse(txtAmount.Text, out amount))
                throw new Exception("El importe tiene que ser un numero. Utilizar al punto (.) como separador decimal. Atencion! No utilizar separadores de miles");
            return amount;
        }

        private void chkCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            pnlCreditCard.Enabled = chkCreditCard.Checked;
        }
    }
}
