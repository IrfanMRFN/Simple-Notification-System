namespace Simple_Notification_System;

public interface INotificationService
{
    void Send(string recipient, string messageBody);
}
