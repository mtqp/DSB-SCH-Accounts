using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using enfoke.Test;
using Accounts;
using enfoke.IO;
using System.Collections.Generic;
using enfoke.OOPS;

namespace AccountTests
{
    [TestClass]
    public class TestsCSVPaymentFile : TestCase
    {
        [TestMethod]
        [TestCategory("CSV")]
        public void Test001WhenOnlyOneEntryItGetsParsedCorrectly()
        {
            CSVPaymentFile csv = CSV(forFile: "american_oneline");

            Payment expected = new Payment(new CreditCard("american"), "c1", new DateTime(2015, 10, 2), dues: 12, amount: 1200);
            IList<Payment> readPayments = csv.Read();

            Assert.AreEqual(1, readPayments.Count, "There should only be one credit card entry");
            Assert.AreEqual(expected, readPayments[0], "Payments are not equal");
        }

        [TestMethod]
        [TestCategory("CSV")]
        public void Test002WhenMoreThanAnEntryExistsItsGetsParsedCorrectly()
        {
            CSVPaymentFile csv = CSV(forFile: "american_multiline");

            IList<Payment> expected = new List<Payment>();
            expected.Add(new Payment(new CreditCard("american"), "c1", new DateTime(2015, 10, 02), 12, 1200));
            expected.Add(new Payment(new CreditCard("visa"), "c2", new DateTime(2015, 10, 01), 1, 200));
            expected.Add(new Payment(new CreditCard("american"), "c3", new DateTime(2015, 10, 03), 3, 115.3));

            IList<Payment> obtained = csv.Read();

            Assert.AreEqual(3, obtained.Count, "There should be 3 credit card entries");
            AssertEqualLists(expected, obtained);
        }

        [TestMethod]
        [TestCategory("CSV")]
        public void Test003WhenReadingACashExpenseItGetsParsedCorrectly()
        {
            CSVPaymentFile csv = CSV(forFile: "cash_oneline");

            IList<Payment> expected = new List<Payment>();
            expected.Add(new Payment(new Cash(), "c1", new DateTime(2015, 10, 02), 1200));

            IList<Payment> obtained = csv.Read();

            AssertEqualLists(expected, obtained);
        }

        protected void AssertEqualLists<T>(IList<T> expected, IList<T> obtained)
        {
            if (expected.Count != obtained.Count)
                Assert.Fail("Collections are from different sizes. Expected: " + expected.Count.ToString() +
                            " but obtained: " + obtained.Count.ToString());

            expected.For((i, expectedItem) =>
            {
                Assert.AreEqual(expectedItem, obtained[i], i.ToString() + " item where not equal");
            });
        }

        protected CSVPaymentFile CSV(string forFile)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "CSVFiles\\" + forFile + ".csv");
            return new CSVPaymentFile(path);
        }

        //string enfokeTestingCertificatePath = );
        //    return new SHA1RSAEncrypter(enfokeTestingCertificatePath);
    }
}
