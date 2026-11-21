namespace HomeWork;

public class Payment
{
    public virtual void Pay(decimal amount)
    {
        Console.WriteLine($"Payment completed: {amount} so'm");
    }
}