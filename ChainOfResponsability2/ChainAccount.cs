namespace DesignPatterns.ChainOfResponsability2;

public class ChainAccount
{
    public double Balance { get; set; }
    public string? Owner { get; set; }

    public ChainAccount(double balance, string owner)
    {
        Balance = balance;
        Owner = owner;
    }
}