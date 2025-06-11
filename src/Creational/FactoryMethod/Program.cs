using FactoryMethod.Bad;

Console.WriteLine("=== BAD EXAMPLE ===");
var badService = new NotificationService();
badService.Send("Email", "john@example.com", "Hello John!");
badService.Send("SMS", "1234567890", "Hi via SMS");
badService.Send("Push", "device-token-xyz", "Push message!");

Console.WriteLine("\n=== REFACTORED EXAMPLE (FACTORY METHOD) ===");
var refactoredService = new FactoryMethod.Refactored.NotificationService();
refactoredService.Send("Email", "jane@example.com", "Welcome Jane!");
refactoredService.Send("SMS", "9876543210", "Hi Jane via SMS");
refactoredService.Send("Push", "device-token-abc", "Push to Jane!");