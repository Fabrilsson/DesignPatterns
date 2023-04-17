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
                return account.Balance * 0.025;

            return account.Balance * 0.007;
        }
    }
}