using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Investment
{
    public class BankAccount
    {
        public double Balance { get; private set; }
        public double Tax { get; private set; }

        public BankAccount(double balance)
        {
            Balance = balance;
        }

        public void Credit(double value)
        {
            var tax = value * 0.25;

            Tax += tax;
            Balance += (value - tax);
        }
    }
}