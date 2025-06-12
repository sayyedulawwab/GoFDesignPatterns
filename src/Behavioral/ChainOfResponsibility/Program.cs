using ChainOfResponsibility.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badServer = new ChainOfResponsibility.Bad.WebServer();
badServer.Handle(new ChainOfResponsibility.Bad.HttpRequest { Username = "admin", Password = "1234" });

Console.WriteLine("\n=== REFACTORED EXAMPLE (CHAIN OF RESPONSIBILITY) ===");
var middleware = new Validator();
middleware
    .LinkWith(new Authenticator())
    .LinkWith(new Logger());

var refactoredServer = new WebServer(middleware);
refactoredServer.Handle(new HttpRequest { Username = "admin", Password = "1234" });
