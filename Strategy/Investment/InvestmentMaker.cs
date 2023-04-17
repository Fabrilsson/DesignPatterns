using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Investment
{
    public class InvestmentMaker
    {
        public void Invest(BankAccount bankAccount, Investment investment)
        {
            var value = investment.Invest(bankAccount);

            bankAccount.Credit(value);

            Console.WriteLine(bankAccount.Balance);
        }
    }
}