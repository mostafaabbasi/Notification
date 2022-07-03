namespace Notification.NotificationServices.Visitors;
public class SMSVisitor : IVisitor
{
    public void Visit(INotificationSender visitor)
    {
        Console.WriteLine("Setup SMS");
    }
}
