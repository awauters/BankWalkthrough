using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod] Bank
        public void Debet_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            Double beginningBalance = 11.99;
            Double debetAmount = 4.55;
            Double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Tom Vervoort", beginningBalance);
            // Act
            account.Debet(debetAmount);
            // Assert
            Double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debeted correctly");
        }

        [TestMethod] Bank
        public void Debet(double amount)
        {
            if (amount > m_balance) {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0) {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance -= amount; // intentionally incorrect code                  }

        }
    }
}
