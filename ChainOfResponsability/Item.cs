namespace DesignPatterns.ChainOfResponsability
{
    public class Item
    {
        public string Name { get; private set; }
        public double Value { get; private set; }

        public Item(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public void ApplyDiscount(double multiplier)
        {
            Value -= Value *= multiplier;
        }
    }
}