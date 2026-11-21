namespace HomeWork;

public class SmsNotification : Notification
{
    public SmsNotification(string recipient, string message)
        : base(recipient, message)
    {
    }

    public override void Send()
    {
        Console.WriteLine("Channel: SMS");
        Console.WriteLine($"Recipient: {Recipient}");
        Console.WriteLine($"Message: {Message}");
    }
}