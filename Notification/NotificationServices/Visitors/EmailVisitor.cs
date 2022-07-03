namespace Notification.NotificationServices.Visitors;
public class EmailVisitor : IVisitor
{
    public void Visit(INotificationSender visitor)
    {
        Console.WriteLine("Setup Email");
    }
}
