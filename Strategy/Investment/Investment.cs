using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Investment
{
    public interface Investment
    {
        public double Invest(BankAccount account);
    }
}