using DesignPatterns.ChainOfResponsability.Interfaces;

namespace DesignPatterns.ChainOfResponsability;

public class PriceDiscount : IDiscount
{
    public IDiscount Next { get; }

    public PriceDiscount(IDiscount discount) =>
        Next = discount;

    public double Apply(ChainBudget budget) 
    {
        if(budget.Value > 500)
        {
            budget.ApplyDiscount(0.07);
            return Next.Apply(budget);
        }
            
        return Next.Apply(budget);
    }
}