using Strategy.Bad;
using Strategy.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var paymentService = new PaymentService();
paymentService.ProcessPayment("Stripe", 100);
paymentService.ProcessPayment("PayPal", 200);
paymentService.ProcessPayment("BankTransfer", 300);


Console.WriteLine("\n=== REFACTORED EXAMPLE (STRATEGY PATTERN) ===");

// Stripe Payment
var processor = new PaymentProcessor(new StripePayment());
processor.Process(100);

// PayPal Payment
processor = new PaymentProcessor(new PayPalPayment());
processor.Process(200);

// Bank Transfer Payment
processor = new PaymentProcessor(new BankTransferPayment());
processor.Process(300);