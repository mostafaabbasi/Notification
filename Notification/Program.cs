var textVisitor = new SMSVisitor();
var emailVisitor = new EmailVisitor();

MarketingNotificationSender notificationSender = new MarketingNotificationSender();

notificationSender.Accept(textVisitor);
notificationSender.Accept(emailVisitor);
notificationSender.Send("Hello");

Console.ReadLine();