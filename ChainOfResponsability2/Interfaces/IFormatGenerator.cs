namespace DesignPatterns.ChainOfResponsability2.Interfaces;

public interface IFormatGenerator
{
    public string Generate(Request request, ChainAccount account);
}