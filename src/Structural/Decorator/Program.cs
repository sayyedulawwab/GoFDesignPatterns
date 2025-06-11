using Decorator.Bad;
using Decorator.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badService = new NotificationService();
badService.Send("Email", "Welcome to our app!");
badService.Send("SMS", "Your OTP is 1234");

Console.WriteLine("\n=== REFACTORED EXAMPLE (DECORATOR PATTERN) ===");

INotificationSender emailSender = new ValidatingNotificationSenderDecorator(new LoggingNotificationSenderDecorator(new EmailNotificationSender()));
emailSender.Send("Welcome to our app!");

INotificationSender smsSender = new ValidatingNotificationSenderDecorator(new LoggingNotificationSenderDecorator(new SmsNotificationSender()));
smsSender.Send("Your OTP is 1234");