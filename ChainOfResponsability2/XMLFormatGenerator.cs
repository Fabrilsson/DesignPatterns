using DesignPatterns.ChainOfResponsability2.Interfaces;

namespace DesignPatterns.ChainOfResponsability2;

public class XMLFormatGenerator : IFormatGenerator
{
    private readonly IFormatGenerator _formatGenerator;

    public XMLFormatGenerator(IFormatGenerator formatGenerator) =>
        _formatGenerator = formatGenerator;

    public string Generate(Request request, ChainAccount account)
    {
        if (request.RequestFormat.Equals(RequestFormat.XML))
            return string.Join("XML", account.Balance, account.Owner);

        return _formatGenerator.Generate(request, account); 
    }
}