using State.Bad;
using State.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badOrder = new Order();
badOrder.Next(); // Pay
badOrder.Next(); // Ship
badOrder.Next(); // Deliver
badOrder.Next(); // Already Delivered

Console.WriteLine("\n=== REFACTORED EXAMPLE (STATE PATTERN) ===");
var refactoredOrder = new OrderContext();
refactoredOrder.Next(); // Pay
refactoredOrder.Next(); // Ship
refactoredOrder.Next(); // Deliver
refactoredOrder.Next(); // Already Delivered
