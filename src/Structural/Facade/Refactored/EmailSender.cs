namespace Facade.Refactored;
public class EmailSender
{
    public void SendEmail(string report)
    {
        Console.WriteLine("Sending Email with Report:\n" + report);
    }
}
