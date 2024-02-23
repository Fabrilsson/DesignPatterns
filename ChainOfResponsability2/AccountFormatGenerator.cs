namespace DesignPatterns.ChainOfResponsability2;

public class AccountFormatGenerator
{
    public string Generate(Request request)
    {
        var account = GetFromPossibleRepository();

        var f4 = new NoFormatGenerator();
        var f3 = new XMLFormatGenerator(f4);
        var f2 = new CSVFormatGenerator(f3);
        var f1 = new PercentFormatGenerator(f2);

        return f1.Generate(request, account);
    }

    private ChainAccount GetFromPossibleRepository()
    {
        return new ChainAccount(1892.12, "Fabrilsson");
    }
}