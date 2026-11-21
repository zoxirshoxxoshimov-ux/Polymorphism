namespace HomeWork;

public class Notification
{
    public string Recipient { get; }
    public string Message { get; }

    public Notification(string recipient, string message)
    {
        Recipient = recipient;
        Message = message;
    }

    public virtual void Send()
    {
        Console.WriteLine("Bildirishnoma yuborildi.");
    }
}