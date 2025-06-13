using Bridge.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badLogger = new Bridge.Bad.Logger();
badLogger.LogErrorToConsole("Something went wrong.");
badLogger.LogErrorToFile("Something went wrong.");
badLogger.LogInfoToConsole("Startup complete.");
badLogger.LogInfoToFile("Startup complete.");
badLogger.LogInfoToConsole("Welcome to the system.");
badLogger.LogInfoToFile("Welcome to the system.");


Console.WriteLine("\n=== REFACTORED EXAMPLE (BRIDGE PATTERN) ===");

// Console Error Logger
var consoleErrorLogger = new ErrorLogger(new ConsoleLogDestination());
consoleErrorLogger.Log("Something went wrong.");

// File Info Logger
var fileInfoLogger = new InfoLogger(new FileLogDestination());
fileInfoLogger.Log("Startup complete.");

// Console Info Logger
var consoleInfoLogger = new InfoLogger(new ConsoleLogDestination());
consoleInfoLogger.Log("Welcome to the system.");
