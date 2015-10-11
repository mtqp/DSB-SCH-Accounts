using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts
{
    public class Cash : PaymentMethod
    {
        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is Cash))
                return false;

            return true;
        }

        public override string ToString()
        {
            return "Efectivo";
        }

        internal override string Due(DateTime forDate, Payment to)
        {
            return to.CashDue(forDate);
        }

        internal override double MonthlyPaying(double withTotalAmount, int andTotalDues)
        {
            return withTotalAmount;
        }
    }
}
