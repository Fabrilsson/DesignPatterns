using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.TaxCalculator
{
    public class Budget
    {
        public double Value { get; }

        public Budget(double value)
        {
            Value = value;
        }
    }
}