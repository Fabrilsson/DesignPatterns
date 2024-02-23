using DesignPatterns.ChainOfResponsability.Interfaces;

namespace DesignPatterns.ChainOfResponsability;

public class PairSaleDiscount : IDiscount
{
    public IDiscount Next { get; }

    public PairSaleDiscount(IDiscount discount) =>
        Next = discount;

    public double Apply(ChainBudget budget) 
    {
        if (budget.Items.Any(i => i.Name.Equals("caneta", StringComparison.InvariantCultureIgnoreCase)) && 
            budget.Items.Any(i => i.Name.Equals("lapis", StringComparison.InvariantCultureIgnoreCase)))
        {
            budget.ApplyDiscount(0.05);
            return Next.Apply(budget);
        }

        return Next.Apply(budget);
    }
}