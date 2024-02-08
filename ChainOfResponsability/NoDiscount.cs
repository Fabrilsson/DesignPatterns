using DesignPatterns.ChainOfResponsability.Interfaces;

namespace DesignPatterns.ChainOfResponsability;

public class NoDiscount : IDiscount
{
    public IDiscount Next { get; }

    public double Apply(ChainBudget budget)
    {
        return budget.Value;
    }
}