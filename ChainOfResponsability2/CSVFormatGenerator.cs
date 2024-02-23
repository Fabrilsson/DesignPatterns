using DesignPatterns.ChainOfResponsability2.Interfaces;

namespace DesignPatterns.ChainOfResponsability2;

public class CSVFormatGenerator : IFormatGenerator
{
    private readonly IFormatGenerator _formatGenerator;

    public CSVFormatGenerator(IFormatGenerator formatGenerator) =>
        _formatGenerator = formatGenerator;

    public string Generate(Request request, ChainAccount account)
    {
        if (request.RequestFormat.Equals(RequestFormat.CSV))
            return string.Join(';', account.Balance, account.Owner);

        return _formatGenerator.Generate(request, account); 
    }
}