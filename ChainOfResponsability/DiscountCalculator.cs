using DesignPatterns.ChainOfResponsability.Interfaces;

namespace DesignPatterns.ChainOfResponsability
{
    public class DiscountCalculator
    {
        public double Calculate(ChainBudget budget)
        {
            var noDiscount = new NoDiscount();
            var d3 = new PairSaleDiscount(noDiscount);
            var d2 = new PriceDiscount(d3);
            var d1 = new QuantityItemDiscount(d2);

            return d1.Apply(budget);
        }
    }
}