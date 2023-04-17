using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Investment
{
    public class Bold : Investment
    {
        public double Invest(BankAccount account)
        {
            var value = new Random().Next(101);

            if (value > 80)
                return account.Balance * 0.5;

            if (value > 50 && value <= 80)
                return account.Balance * 0.3;

            return account.Balance * 0.06;
        }
    }
}