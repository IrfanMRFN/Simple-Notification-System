namespace SimpleNotificationSystem;

public class PushNotificationService : INotificationService
{
    public void Send(string recipient, string messageBody)
    {
        Console.WriteLine($"\nPush notification dispatched to app user <{recipient}>");
        Console.WriteLine("-------------------------------");
        Console.WriteLine(messageBody);
    }
}
