namespace Prototype.Bad;
public class EmailSender
{
    public void SendEmail()
    {
        var welcomeEmail = new EmailTemplate(
            "Welcome!",
            "Hi, thank you for joining our platform.",
            new List<string> { "welcome", "user" });

        var promoEmail = new EmailTemplate(
            "Special Offer!",
            "Here's a 50% discount just for you.",
            new List<string> { "promo", "offer" });

        Console.WriteLine(welcomeEmail.Subject);
        Console.WriteLine(promoEmail.Subject);
    }
}
