using Command.Bad;
using Command.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badService = new OrderService();
badService.Execute("PlaceOrder");
badService.Execute("CancelOrder");

Console.WriteLine("\n=== REFACTORED EXAMPLE (COMMAND PATTERN) ===");

var handler = new OrderHandler();

handler.RunCommand(new PlaceOrderCommand());
handler.RunCommand(new CancelOrderCommand());

Console.WriteLine("\n=== REFACTORED EXAMPLE (COMMAND PATTERN) + Command Queue ===");

var queue = new CommandQueue();
queue.AddCommand(new PlaceOrderCommand());
queue.AddCommand(new CancelOrderCommand());

Console.WriteLine("\nProcessing command queue...");
queue.ProcessAll();