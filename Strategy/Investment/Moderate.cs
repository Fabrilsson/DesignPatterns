using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Investment
{
    public class Moderate : Investment
    {
        public double Invest(BankAccount account)
        {
            if (new Random().Next(101) > 50)
                return account.Balance * 0.25;

            return account.Balance * 0.07;
        }
    }
}