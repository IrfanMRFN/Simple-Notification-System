namespace Simple_Notification_System;

public class SmsService : INotificationService
{
    public void Send(string recipient, string messageBody)
    {
        if (int.TryParse(recipient, out int result))
        {
            Console.WriteLine($"\nSending message to {recipient}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(messageBody);
        }
        else
        {
            Console.WriteLine("\nMessage not sent! Invalid number.");
        }
    }
}
