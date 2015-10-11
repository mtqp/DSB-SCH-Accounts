using enfoke.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using enfoke.OOPS;

namespace Accounts
{
    public class CSVPaymentFile
    {
        protected string filename;
        protected const char SEPARATOR = ';';
        protected const int PAYMENT_PARAMETER_COUNT = 5;
        protected const string DATE_FORMAT = "yyyyMMdd";
        protected const string FULL_FORMAT = "yyyyMMddHHmmssmmmm";

        public CSVPaymentFile(string filename)
        {
            // TODO: Complete member initialization
            this.filename = filename;
        }

        public IList<Payment> Read()
        {
            List<Payment> payments = new List<Payment>();

            string[] values = FileSplittedByEnters().Select(line => line.Split(SEPARATOR))
                                                    .Flatten()
                                                    .ToArray();

            if (values.Length % PAYMENT_PARAMETER_COUNT != 0)
                throw new Exception("File format incorrect, length is: " + values.Length.ToString());

            for (int i = 0; i < values.Length; i += PAYMENT_PARAMETER_COUNT)
            {
                string concept = values[i + 1].Trim();
                DateTime entryDate = DateTime.ParseExact(values[i + 2].Trim(), DATE_FORMAT, System.Globalization.CultureInfo.CurrentCulture);
                double amount = double.Parse(values[i + 4].Trim(), System.Globalization.NumberStyles.Number);

                string dues = values[i + 3].Trim();

                (dues == "-").IfTrue(() =>
                { 
                    payments.Add(new Payment(new Cash(), concept, entryDate, amount));
                })
                .IfFalse(() => 
                {
                    CreditCard creditCard = new CreditCard(values[i].Trim());
                    payments.Add(new Payment(creditCard, concept, entryDate, int.Parse(dues), amount));
                });
                
            }

            return payments;
        }

        private string[] FileSplittedByEnters()
        {
            return File.ReadAllText(filename).Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        internal void Save(IEnumerable<Payment> withPayments)
        {
            string bckName = filename + "bck"+ DateTime.Now.ToString(FULL_FORMAT);
            File.Copy(filename, bckName);

            StringBuilder csvBuilder = new StringBuilder();
            
            withPayments.ForEach(payment =>
            {
                csvBuilder.AppendLine(ToCSV(payment));
            });

            File.Delete(filename);

            File.WriteAllText(filename, csvBuilder.ToString());

            File.Delete(bckName);
        }

        private string ToCSV(Payment payment)
        {
            /*
             * Esta mal esto, deberia poder hacerlo con reflection, 
             * o algo que no exponga todo para afuera, rompiendo
             * el encapsulamiento
             */
            string dues = payment.TotalDues != 0 ? payment.TotalDues.ToString() : "-";
            
            return payment.Name + SEPARATOR +
                   payment.Concept + SEPARATOR +
                   payment.EntryDate.ToString(DATE_FORMAT) + SEPARATOR +
                   dues + SEPARATOR +
                   payment.TotalAmount.ToString();
        }
    }
}
