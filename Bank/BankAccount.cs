using System;

namespace Bank
{
    /// <summary>
    /// Bank account demo class
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }
        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }
        public void Debet(double debetAmount)
        {
            throw new NotImplementedException();
        }
    }
}
