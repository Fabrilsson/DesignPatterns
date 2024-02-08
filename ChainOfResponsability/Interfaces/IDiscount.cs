namespace DesignPatterns.ChainOfResponsability.Interfaces
{
    public interface IDiscount
    {
        double Apply(ChainBudget budget);
        IDiscount Next { get; }
    }
}