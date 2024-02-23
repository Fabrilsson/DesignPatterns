using DesignPatterns.ChainOfResponsability2.Interfaces;

namespace DesignPatterns.ChainOfResponsability2;

public class NoFormatGenerator : IFormatGenerator
{
    public string Generate(Request request, ChainAccount account)
    {
        return string.Empty;
    }
}