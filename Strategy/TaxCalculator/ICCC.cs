using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.TaxCalculator
{
    public class ICCC : Tax
    {
        public double Calculate(Budget budget)
        {
            if (budget.Value < 1000)
                return budget.Value * 0.05;

            if (budget.Value >= 1000 && budget.Value <= 3000)
                return budget.Value * 0.07;

            return (budget.Value * 0.08) + 30;            
        }
    }
}