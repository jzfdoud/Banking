using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Account
    {

        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdrawl(decimal amount)
        {
            Balance -= amount;
        }

        public Account() { }
    }
}
