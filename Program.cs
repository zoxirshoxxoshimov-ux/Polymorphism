using HomeWork;
using System;

// Task_1 

Console.WriteLine("\n====================");

Notification[] notifications =
{
    new EmailNotification("ali@gmail.com", "Hello Ali!"),
    new SmsNotification("+998901234567", "Your code is 1234.")
};

foreach (Notification notification in notifications)
{
    notification.Send();
}

// Task_2 

Console.WriteLine("\n====================");

Payment[] payments =
{
    new CardPayment(),
    new BankTransferPayment(),
    new WalletPayment()
};

foreach (Payment payment in payments)
{
    payment.Pay(50000);
}

// Task_3 

Console.WriteLine("\n====================");

ReportPrinter printer = new ReportPrinter();

printer.Print("Oylik hisobot");

printer.Print("Oylik hisobot", 125000);
