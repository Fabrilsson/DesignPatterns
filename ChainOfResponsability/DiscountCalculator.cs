using DesignPatterns.ChainOfResponsability.Interfaces;

namespace DesignPatterns.ChainOfResponsability
{
    public class DiscountCalculator
    {
        public double Calculate(ChainBudget budget)
        {
            var noDiscount = new NoDiscount();
            var d2 = new PriceDiscount(noDiscount);
            var d1 = new QuantityItemDiscount(d2);

            return d1.Apply(budget);
        }
    }
}