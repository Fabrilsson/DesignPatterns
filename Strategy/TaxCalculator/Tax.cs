using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.TaxCalculator
{
    public interface Tax
    {
        double Calculate(Budget budget);
    }
}