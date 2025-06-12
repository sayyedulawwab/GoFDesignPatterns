using Proxy.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badService = new Proxy.Bad.PaymentService();
badService.Pay(100);
badService.Pay(200); // Likely to be rate-limited
Thread.Sleep(6000);
badService.Pay(300);

Console.WriteLine("\n=== REFACTORED EXAMPLE (PROXY PATTERN) ===");
var realGateway = new RealPaymentGateway();
var proxy = new RateLimitingProxy(realGateway);
var goodService = new Proxy.Refactored.PaymentService(proxy);
goodService.Pay(100);
goodService.Pay(200); // Likely to be rate-limited
Thread.Sleep(6000);
goodService.Pay(300);