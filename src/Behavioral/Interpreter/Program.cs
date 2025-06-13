using Interpreter.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");

Interpreter.Bad.User user1 = new() { Age = 25, Country = "US", Status = "Inactive", Points = 1200 };

var badFilter = new Interpreter.Bad.UserFilterService();
Console.WriteLine(badFilter.Filter(user1, "age > 18 AND country == US"));        // True
Console.WriteLine(badFilter.Filter(user1, "status == Active OR points > 1000"));  // True


Console.WriteLine("\n=== REFACTORED EXAMPLE (INTERPRETER PATTERN) ===");

User user2 = new() { Age = 25, Country = "US", Status = "Inactive", Points = 1200 };

var interpreter = new UserFilterInterpreter();

var expr1 = interpreter.Parse("age > 18 AND country == US");
Console.WriteLine(expr1.Interpret(user2));  // True

var expr2 = interpreter.Parse("status == Active OR points > 1000");
Console.WriteLine(expr2.Interpret(user2));  // True
