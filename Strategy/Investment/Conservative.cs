using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Investment
{
    public class Conservative : Investment
    {
        public double Invest(BankAccount account)
        {
            return account.Balance * 0.08;
        }
    }
}