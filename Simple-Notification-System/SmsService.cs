namespace SimpleNotificationSystem;

public class SmsService : INotificationService
{
    public void Send(string recipient, string messageBody)
    {
        bool isValidNumber = !string.IsNullOrWhiteSpace(recipient) && recipient.All(char.IsAsciiDigit);

        if (isValidNumber)
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
