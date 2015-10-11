using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using enfoke.OOPS;

namespace Accounts
{
    public partial class frmAccounts : Form
    {
        IList<Payment> payments;

        public frmAccounts()
        {
            InitializeComponent();

            payments = new CSVPaymentFile(FileName()).Read();

            SetComboPaymentMethod();
            SetMonthAndYear();

            SetEvents();
        }

        private void SetMonthAndYear()
        {
            monthUpDown.Value = DateTime.Now.Month;
            yearUpDown.Value = DateTime.Now.Year;
        }

        private void SetComboPaymentMethod()
        {
            List<string> paymentMethodDescriptions = new List<string>() { "Todos" };
            paymentMethodDescriptions.AddRange(payments.Select(payment => payment.Name)
                                                       .Distinct()
                                                       .OrderBy(value => value)
                                                       .ToList());
            cmbPaymentMethod.DataSource = paymentMethodDescriptions;
        }

        private void SetEvents()
        {
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.WindowRefresh);
            this.monthUpDown.ValueChanged += new System.EventHandler(this.WindowRefresh);
            this.yearUpDown.ValueChanged += new System.EventHandler(this.WindowRefresh);
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void LoadPayments()
        {
            slv.BeginUpdate();
            slv.Items.Clear();

            var payments = FilteredPayments().OrderBy(payment => payment.Name);

            payments.ForEach(payment =>
            {
                ListViewItem lvi = new ListViewItem(payment.Name);
                
                lvi.SubItems.Add(payment.Concept);
                lvi.SubItems.Add(payment.Due(forDate: SelectedDate()));
                lvi.SubItems.Add(payment.DueAmount().ToString());
                lvi.Tag = payment;
                
                slv.Items.Add(lvi);
            });

            slv.EndUpdate();

            lblToPay.Text = "Total a pagar: " + payments.Sum(payment => payment.DueAmount()).ToString();
        }

        private DateTime SelectedDate()
        {
            return new DateTime(year: (int)yearUpDown.Value, month: (int)monthUpDown.Value, day:1);
        }

        private IEnumerable<Payment> FilteredPayments()
        {
            var filtered = payments.Where(payment => payment.HasInformation(forDate: SelectedDate()));

            if ((string)cmbPaymentMethod.SelectedItem != "Todos")
                filtered = filtered.Where(payment => payment.Name == (string)cmbPaymentMethod.SelectedItem);

            return filtered;
        }

        private string FileName()
        {
            return Path.Combine(Environment.CurrentDirectory, "CSVFiles\\datos_crudos.csv");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new CSVPaymentFile(FileName()).Save(withPayments: payments);
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var newPaymentWindow = new frmNewPayment();

            (newPaymentWindow.ShowDialog() == DialogResult.OK).IfTrue(() =>
            {
                string selectedItem = cmbPaymentMethod.SelectedItem as string;
                payments.Add(newPaymentWindow.Payment);
                SetComboPaymentMethod();
                cmbPaymentMethod.SelectedItem = selectedItem;
            });
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Hola! Todavia estoy en proceso de desarrollo, no tengo mas detalle para mostrarte!! :S", "De Sousa - Scheiner - Cuentas");
        }

        private void WindowRefresh(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (slv.SelectedItem.IsNotNull())
            {
                DialogResult response = MessageBox.Show(this,"Estas seguro que queres eliminar este registro?", "De Sousa - Scheiner - Cuentas", MessageBoxButtons.OKCancel);

                (response == DialogResult.OK).IfTrue(() =>
                {
                    payments.Remove(slv.SelectedItem.Tag as Payment);
                    LoadPayments();
                });
            }
            else
            {
                MessageBox.Show(this, "Por favor selecciona un item para remover", "De Sousa - Scheiner - Cuentas");
            }
        }
    }
}
