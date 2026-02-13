namespace SimpleNotificationSystem;

public interface INotificationService
{
    void Send(string recipient, string messageBody);
}
