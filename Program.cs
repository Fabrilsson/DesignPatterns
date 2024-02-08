using DesignPatterns.ChainOfResponsability;
using DesignPatterns.Strategy.Investment;
using DesignPatterns.Strategy.TaxCalculator;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunStrategyPattern();

            RunChainPattern();
        }

        static void RunStrategyPattern()
        {
            Tax iss = new ISS();
            Tax icms = new ICMS();
            Tax iccc = new ICCC();

            Budget budget = new Budget(1100);

            TaxCalculator taxCalculator = new TaxCalculator();

            taxCalculator.Calculate(budget, iss);
            taxCalculator.Calculate(budget, icms);
            taxCalculator.Calculate(budget, iccc);

            var bankAccount = new BankAccount(5500);

            Investment conservative = new Conservative();
            Investment moderate = new Moderate();
            Investment bold = new Bold();

            InvestmentMaker investmentMaker = new InvestmentMaker();

            investmentMaker.Invest(bankAccount, conservative);
            investmentMaker.Invest(bankAccount, moderate);
            investmentMaker.Invest(bankAccount, bold);

            Console.ReadLine();
        }

        static void RunChainPattern()
        {
            var calculator = new DiscountCalculator();

            var budget = new ChainBudget(1050.0);
            budget.AddItem(new Item("CANETA", 800.0));
            budget.AddItem(new Item("LAPIS", 250.0));

            double desconto = calculator.Calculate(budget);

            Console.WriteLine(desconto);
        }
    }
}