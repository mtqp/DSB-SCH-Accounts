using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using enfoke.OOPS;
using enfoke.OOPS.Reflection;
using Accounts;

namespace AccountTests
{
    [TestClass]
    public class TestsPayment
    {
        private const string PAYMENT = "Payment";

        [TestMethod]
        [TestCategory(PAYMENT)]
        public void Test001WhenCreditCardPaymentAmountShould1thOfDueAmount()
        {
            var payment = CreditCardPaymentOf10In10Dues();

            Assert.AreEqual(1, payment.DueAmount());
        }

        [TestMethod]
        [TestCategory(PAYMENT)]
        public void Test002WhenCashPaymentAmountShouldBeSameAsDueAmount()
        {
            var payment = CashPaymentOf10();

            Assert.AreEqual(10, payment.DueAmount());
        }

        [TestMethod]
        [TestCategory(PAYMENT)]
        public void Test003WhenCashPaymentDueShouldBeAHypen()
        {
            var payment = CashPaymentOf10();

            Assert.AreEqual("-", payment.Due(DateTime.Now));
        }

        [TestMethod]
        [TestCategory(PAYMENT)]
        public void Test004WhenCreditCardPaymentDatePriorNowDueIs0()
        {
            var payment = CreditCardPaymentOf10In10Dues();
            
            Assert.AreEqual("0/10", payment.Due(forDate: DateTime.Now.AddMonths(-1)));
        }

        [TestMethod]
        [TestCategory(PAYMENT)]
        public void Test005WhenCreditCardPaymentDateIsSameMonthAsCreatedIs1()
        {
            var payment = CreditCardPaymentOf10In10Dues();
            Assert.AreEqual("1/10", payment.Due(forDate: DateTime.Now));
        }

        [TestMethod]
        [TestCategory(PAYMENT)]
        public void Test005WhenCreditCardPaymentDateInTheFutureButNotAllPayedIsSaysTheCorrectMonth()
        {
            var payment = CreditCardPaymentOf10In10Dues();
            Assert.AreEqual("4/10", payment.Due(forDate: DateTime.Now.AddMonths(3)));
        }

        [TestMethod]
        [TestCategory(PAYMENT)]
        public void Test005WhenCreditCardPaymentDateInTheLastMonthItSaysLastMonth()
        {
            var payment = CreditCardPaymentOf10In10Dues();
            Assert.AreEqual("10/10", payment.Due(forDate: DateTime.Now.AddMonths(9)));
        }

        [TestMethod]
        [TestCategory(PAYMENT)]
        public void Test005WhenCreditCardPaymentDateAlreadyPayedSaysAlreadyPayed()
        {
            var payment = CreditCardPaymentOf10In10Dues();
            Assert.AreEqual("Pagado", payment.Due(forDate: DateTime.Now.AddMonths(11)));
        }

        private static Payment CashPaymentOf10()
        {
            var payment = new Payment(new Cash(), "c1", DateTime.Now, amount: 10);
            return payment;
        }

        private static Payment CreditCardPaymentOf10In10Dues()
        {
            var payment = new Payment(new CreditCard("blah"), "c1", DateTime.Now, dues: 10, amount: 10);
            return payment;
        }
    }
}
