namespace Notification.Interfaces;
public interface INotificationSender
{
    void Send(string message);
    void Accept(IVisitor visitor);
}
