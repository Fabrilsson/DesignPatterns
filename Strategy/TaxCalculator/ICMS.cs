using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.TaxCalculator
{
    public class ICMS : Tax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}