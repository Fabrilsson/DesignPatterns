using DesignPatterns.Strategy.Investment;
using DesignPatterns.Strategy.TaxCalculator;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
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
    }
}