using DesignPatterns.ChainOfResponsability;
using DesignPatterns.ChainOfResponsability2;
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

            RunSecondChainPattern();

            Console.ReadLine();
        }

        static void RunStrategyPattern()
        {
            Tax iss = new ISS();
            Tax icms = new ICMS();
            Tax iccc = new ICCC();

            Budget budget = new Budget(1100);

            TaxCalculator taxCalculator = new TaxCalculator();

            Console.WriteLine();
            Console.WriteLine("Strategy Pattern 1");
            Console.WriteLine();

            taxCalculator.Calculate(budget, iss);
            taxCalculator.Calculate(budget, icms);
            taxCalculator.Calculate(budget, iccc);

            Console.WriteLine();
            Console.WriteLine("Stragegy Pattern 2");
            Console.WriteLine();

            var bankAccount = new BankAccount(5500);

            Investment conservative = new Conservative();
            Investment moderate = new Moderate();
            Investment bold = new Bold();

            InvestmentMaker investmentMaker = new InvestmentMaker();

            investmentMaker.Invest(bankAccount, conservative);
            investmentMaker.Invest(bankAccount, moderate);
            investmentMaker.Invest(bankAccount, bold);
        }

        static void RunChainPattern()
        {
            Console.WriteLine();
            Console.WriteLine("Chain Pattern 1");
            Console.WriteLine();

            var calculator = new DiscountCalculator();

            var budget = new ChainBudget(1050.0);
            budget.AddItem(new Item("CANETA", 800.0));
            budget.AddItem(new Item("LAPIS", 250.0));

            double desconto = calculator.Calculate(budget);

            Console.WriteLine(desconto);
        }

        static void RunSecondChainPattern()
        {
            Console.WriteLine();
            Console.WriteLine("Chain Pattern 2");
            Console.WriteLine();

            var formatGenerator = new AccountFormatGenerator();

            var result1 = formatGenerator.Generate(new Request(RequestFormat.XML));

            var result2 = formatGenerator.Generate(new Request(RequestFormat.CSV));

            var result3 = formatGenerator.Generate(new Request(RequestFormat.PERCENTAGE));

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}