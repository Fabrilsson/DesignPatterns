using DesignPatterns.ChainOfResponsability.Interfaces;

namespace DesignPatterns.ChainOfResponsability;

public class QuantityItemDiscount : IDiscount
{
    public IDiscount Next { get; }

    public QuantityItemDiscount(IDiscount discount) =>
        Next = discount;

    public double Apply(ChainBudget budget) 
    {
        if(budget.Items.Count > 5)
        {
            budget.ApplyDiscount(0.1);
            return Next.Apply(budget);
        }

        return Next.Apply(budget);
    }
}