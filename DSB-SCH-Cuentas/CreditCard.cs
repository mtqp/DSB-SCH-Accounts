using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts
{
    public class CreditCard : PaymentMethod
    {
        private string cardName;

        public CreditCard(string cardName)
        {
            this.cardName = cardName;
        }

        internal override double MonthlyPaying(double withTotalAmount, int andTotalDues)
        {
            return withTotalAmount / andTotalDues;
        }

        internal override string Due(DateTime forDate, Payment to)
        {
            return to.CreditCardDue(forDate);
        }

        public override string ToString()
        {
            return this.cardName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is CreditCard))
                return false;

            return this.cardName.ToUpper().Equals(((CreditCard)obj).cardName.ToUpper());
        }

    }
}
