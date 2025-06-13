using Visitor.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");

var badProcessor = new Visitor.Bad.NotificationProcessor();

var emailBad = new Visitor.Bad.EmailNotification { Email = "user@example.com", Message = "Hello Email" };
var smsBad = new Visitor.Bad.SMSNotification { PhoneNumber = "1234567890", Message = "Hello SMS" };
var pushBad = new Visitor.Bad.PushNotification { DeviceId = "device123", Message = "Hello Push" };

badProcessor.Log(emailBad);
badProcessor.Send(smsBad);
badProcessor.Audit(pushBad);

Console.WriteLine("\n=== REFACTORED EXAMPLE (VISITOR PATTERN) ===");

var email = new EmailNotification { Email = "user@example.com", Message = "Hello Email" };
var sms = new SMSNotification { PhoneNumber = "1234567890", Message = "Hello SMS" };
var push = new PushNotification { DeviceId = "device123", Message = "Hello Push" };

var loggingVisitor = new LoggingVisitor();
var sendingVisitor = new SendingVisitor();
var auditingVisitor = new AuditingVisitor();

List<INotification> notifications = new() { email, sms, push };

foreach (var notification in notifications)
{
    notification.Accept(loggingVisitor);
    notification.Accept(sendingVisitor);
    notification.Accept(auditingVisitor);
}
