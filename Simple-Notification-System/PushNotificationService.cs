namespace Simple_Notification_System;

public class PushNotificationService : INotificationService
{
    public void Send(string recipient, string messageBody)
    {
        Console.WriteLine($"\nPush notification dispatched to app user <{recipient}>");
        Console.WriteLine("-------------------------------");
        Console.WriteLine(messageBody);
    }
}
