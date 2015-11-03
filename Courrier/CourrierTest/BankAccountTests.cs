using Microsoft.VisualStudio.TestTools.UnitTesting;
using pqtcity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcity.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        BankAccount objBankAccount;

        [TestMethod()]
        public void IfObjectNotNull()
        {
            objBankAccount = new BankAccount();
            Assert.IsNotNull(objBankAccount);
        }

        [TestMethod()]
        public void setCreditTest()
        {
            objBankAccount = new BankAccount();
            objBankAccount.setCredit(5.0);
            Assert.AreEqual(5005, objBankAccount.getAmount());
        }

        [TestMethod()]
        public void setDebitTest()
        {
            objBankAccount = new BankAccount();
            objBankAccount.setDebit(5.0);
            Assert.AreEqual(4995, objBankAccount.getAmount());
        }

        [TestMethod()]
        public void getAmountTest()
        {
            objBankAccount = new BankAccount();
            Assert.AreEqual(5000, objBankAccount.getAmount());
        }
    }
}