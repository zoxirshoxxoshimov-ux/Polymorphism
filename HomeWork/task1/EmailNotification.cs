namespace HomeWork;

public class EmailNotification : Notification
{
    public EmailNotification(string recipient, string message)
        : base(recipient, message)
    {
    }

    public override void Send()
    {
        Console.WriteLine("Channel: Email");
        Console.WriteLine($"Recipient: {Recipient}");
        Console.WriteLine($"Message: {Message}");
    }
}