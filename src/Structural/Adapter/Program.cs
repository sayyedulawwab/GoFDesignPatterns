using Adapter.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badService = new Adapter.Bad.PaymentService();
badService.ProcessStripePayment(150);


Console.WriteLine("\n=== REFACTORED EXAMPLE (ADAPTER PATTERN) ===");
var stripeSdk = new StripeSdk();
var adapter = new StripeAdapter(stripeSdk);
var refactoredService = new PaymentService(adapter);
refactoredService.Pay(150);