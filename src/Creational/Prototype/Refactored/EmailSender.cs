namespace Prototype.Refactored;
public class EmailSender
{
    public void SendClonedEmails()
    {
        var baseTemplate = new EmailTemplate(
            "Default Subject",
            "Default Body",
            new List<string> { "base", "branding", "footer" });

        var welcomeEmail = baseTemplate.Clone();
        welcomeEmail.Subject = "Welcome!";
        welcomeEmail.Body = "Hi, thank you for joining our platform.";
        welcomeEmail.Tags.Add("welcome");

        var promoEmail = baseTemplate.Clone();
        promoEmail.Subject = "Special Offer!";
        promoEmail.Body = "Here's a 50% discount just for you.";
        promoEmail.Tags.Add("promo");

        Console.WriteLine(welcomeEmail.Subject);
        Console.WriteLine(promoEmail.Subject);
    }
}
