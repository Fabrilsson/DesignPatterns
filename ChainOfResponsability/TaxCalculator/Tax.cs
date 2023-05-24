using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability.TaxCalculator
{
    public interface Tax
    {
        double Calculate(Budget budget);
    }
}