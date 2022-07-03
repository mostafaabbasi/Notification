namespace Notification.Interfaces;

public interface IVisitor
{
    void Visit(INotificationSender visitor);
}
