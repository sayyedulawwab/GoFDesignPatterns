using Mediator.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badService = new Mediator.Bad.UserService();
badService.CreateUser("muhammad");

Console.WriteLine("\n=== REFACTORED EXAMPLE (MEDIATOR PATTERN) ===");

var notification = new NotificationService();
var logger = new LoggingService();
var auditor = new AuditService();
var mediator = new AppMediator(notification, logger, auditor);

var userService = new UserService();
userService.SetMediator(mediator);
userService.CreateUser("muhammad");
