using Builder.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badEmail = new Builder.Bad.EmailMessage(
           "contact@example.com",
           "Welcome!",
           "Thanks for joining.",
           attachments: new List<string> { "welcome.pdf" }
       );

badEmail.Send();

Console.WriteLine("\n=== REFACTORED EXAMPLE (BUILDER PATTERN) ===");
var refactoredEmail = new EmailMessageBuilder()
            .To("contact@example.com")
            .Subject("Welcome!")
            .Body("Thanks for joining our platform.")
            .AddAttachment("welcome.pdf")
            .Build();

refactoredEmail.Send();