using Prototype.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badSender = new Prototype.Bad.EmailSender();
badSender.SendEmail();

Console.WriteLine("\n=== REFACTORED EXAMPLE (PROTOTYPE PATTERN) ===");
var goodSender = new EmailSender();
goodSender.SendClonedEmails();
