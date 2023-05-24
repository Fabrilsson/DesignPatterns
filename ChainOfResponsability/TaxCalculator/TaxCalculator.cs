using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability.TaxCalculator
{
    public class TaxCalculator
    {
        public void Calculate(Budget budget, Tax tax)
        {
            double result = tax.Calculate(budget);
            Console.WriteLine(result);
        }
    }
}