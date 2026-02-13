namespace Simple_Notification_System;

public class Program
{
    static void Main()
    {
        List<INotificationService> notifications = new List<INotificationService>();
        INotificationService email = new EmailService();
        INotificationService sms = new SmsService();
        INotificationService pushNotification = new PushNotificationService();

        notifications.Add(email);
        notifications.Add(sms);
        notifications.Add(pushNotification);

        foreach (INotificationService notification in notifications)
        {
            notification.Send("JohnDoe@Mail.com", "Your OTP is 1234");
        }

        Console.WriteLine("\nSending message using the correct phone number format...");
        sms.Send("021999999", "Your OTP is 1234");
    }
}