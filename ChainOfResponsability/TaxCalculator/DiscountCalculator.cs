using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability.TaxCalculator
{
    public class DiscountCalculator
    {
        public double Calculate(Budget budget)
        {
            if (budget.Items.Count > 5)
                return budget.Value * 0.1;
            
            if (budget.Value > 500.0)
                return budget.Value * 0.07;

            return 0;
        }
    }
}