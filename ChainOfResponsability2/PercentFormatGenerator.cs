using DesignPatterns.ChainOfResponsability2.Interfaces;

namespace DesignPatterns.ChainOfResponsability2;

public class PercentFormatGenerator : IFormatGenerator
{
    private readonly IFormatGenerator? _formatGenerator;

    public PercentFormatGenerator(IFormatGenerator? formatGenerator = null) =>
        _formatGenerator = formatGenerator;

    public string Generate(Request request, ChainAccount account)
    {
        if (request.RequestFormat.Equals(RequestFormat.PERCENTAGE))
            return string.Join('%', account.Balance, account.Owner);

        if(_formatGenerator is not null)
            return _formatGenerator.Generate(request, account);

        return string.Empty;
    }
}