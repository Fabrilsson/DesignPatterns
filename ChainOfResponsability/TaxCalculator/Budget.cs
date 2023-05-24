using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability.TaxCalculator
{
    public class Budget
    {
        public double Value { get; private set; }
        public IList<Item> Items { get; private set; }

        public Budget(double value)
        {
            Value = value;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}