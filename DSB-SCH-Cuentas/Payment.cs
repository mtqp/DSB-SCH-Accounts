using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using enfoke.OOPS;
using enfoke.Refactor;

namespace Accounts
{
    public class Payment
    {
        protected PaymentMethod method;
        protected double amount;
        protected string concept;
        protected DateTime entryDate;
        protected int dues;

        public Payment(PaymentMethod method, string concept, DateTime entryDate, int dues, double amount)
        {
            this.method = method;
            this.concept = concept;
            this.entryDate = entryDate;
            this.dues = dues;
            this.amount = amount;
        }

        public Payment(Cash cash, string concept, DateTime entryDate, double amount)
            : this(cash, concept, entryDate, 0, amount) { }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Payment))
                return false;

            Payment other = (Payment)obj;

            return this.method.Equals(other.method) &&
                   this.concept.ToUpper().Equals(other.concept.ToUpper()) &&
                   this.amount.Equals(other.amount) &&
                   this.entryDate.Equals(other.entryDate) &&
                   this.dues.Equals(other.dues);
        }

        //Este metodo puede estar mal implementado... pensarlo
        public override int GetHashCode()
        {
            return this.method.GetHashCode() ^
                   this.amount.GetHashCode() ^
                   this.entryDate.GetHashCode();
        }

        public override string ToString()
        {
            return "[" + method.ToString() + ": " +
                         concept + ", " +
                         entryDate.ToString("yyyyMMdd") + ", " +
                         dues.ToString() + ", " +
                         amount.ToString() + "]";
        }

        public PaymentMethod Method { get { return this.method; } }

        public string Name { get { return method.ToString(); } }

        public string Concept { get { return this.concept; } }

        public DateTime EntryDate { get { return this.entryDate; } }

        public int TotalDues { get { return dues; } }
        
        public double TotalAmount { get { return amount; } }

        public string Due(DateTime forDate)
        {
            return method.Due(forDate, to: this);
        }

        public double DueAmount()
        {
            return method.MonthlyPaying(withTotalAmount: amount, andTotalDues: dues);
        }

        internal string CreditCardDue(DateTime forDate)
        {
            var diffMonths = DifferenceInMonths(forDate) + 1;

            if (diffMonths > dues)
                return "Pagado";

            return diffMonths.ToString() + "/" + dues.ToString();
        }

        internal string CashDue(DateTime forDate)
        {
            return "-";
        }

        private int DifferenceInMonths(DateTime forDate)
        {
            var diffMonths = (forDate.Month + forDate.Year * 12) -
                 (entryDate.Month + entryDate.Year * 12);
            return diffMonths;
        }


        [MustRefactor]
        internal bool HasInformation(DateTime forDate)
        {
            if(this.method is CreditCard)
            {
                int monthDiff = DifferenceInMonths(forDate);
                return monthDiff < dues;
            }

            //Else this is a cash payment
            return this.entryDate.Month == forDate.Month &&
                   this.entryDate.Year == forDate.Year;

        }
    }
}
