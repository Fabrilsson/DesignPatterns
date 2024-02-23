namespace DesignPatterns.ChainOfResponsability
{
    public class ChainBudget
    {
        public double Value { get; private set; }
        public IList<Item> Items { get; private set; }

        public ChainBudget(double value)
        {
            Value = value;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void ApplyDiscount(double multiplier)
        {
            Value -= Value *= multiplier;

            foreach(var item in Items)
                item.ApplyDiscount(multiplier);
        }
    }
}