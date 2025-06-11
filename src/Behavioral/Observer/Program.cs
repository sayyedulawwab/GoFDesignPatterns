using Observer.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badOrderService = new Observer.Bad.OrderService();
badOrderService.PlaceOrder("customer@example.com", "+123456789");

Console.WriteLine("\n=== REFACTORED EXAMPLE (OBSERVER PATTERN) ===");
var refactoredOrderService = new OrderService();
refactoredOrderService.Attach(new EmailNotifier());
refactoredOrderService.Attach(new SMSNotifier());

refactoredOrderService.PlaceOrder("customer@example.com", "+123456789");