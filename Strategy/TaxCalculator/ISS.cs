using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.TaxCalculator
{
    public class ISS : Tax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.6;
        }
    }
}