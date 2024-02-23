namespace DesignPatterns.ChainOfResponsability2;

public class Request
{
    public RequestFormat RequestFormat { get; private set; }

    public Request(RequestFormat requestFormat)
    {
        RequestFormat = requestFormat;
    }
}