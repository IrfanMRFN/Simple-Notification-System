namespace SimpleNotificationSystem;

public class Program
{
    static void Main()
    {
        var notifications = new List<INotificationService>()
        {
            new EmailService(),
            new SmsService(),
            new PushNotificationService()
        };

        SendBlast(notifications, "JohnDoe@Mail.com", "Your OTP is 1234");


        Console.WriteLine("\nSending message using the correct phone number format...");
        var sms = new SmsService();
        sms.Send("021999999", "Your OTP is 1234");
    }

    static void SendBlast(List<INotificationService> services, string recipient, string msg)
    {
        Console.WriteLine($"Starting Broadcast to {recipient}...");
        foreach (var service in services)
        {
            service.Send(recipient, msg);
        }
    }
}