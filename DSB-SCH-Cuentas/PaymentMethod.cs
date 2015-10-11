using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts
{
    public abstract class PaymentMethod
    {
        internal abstract double MonthlyPaying(double withTotalAmount, int andTotalDues);

        internal abstract string Due(DateTime forDate, Payment to);
    }
}
