namespace SimpleNotificationSystem;

public class EmailService : INotificationService
{
    public void Send(string recipient, string messageBody)
    {
        Console.WriteLine($"\nSending email to <{recipient}>");
        Console.WriteLine("-------------------------------");
        Console.WriteLine(messageBody);
    }
}
