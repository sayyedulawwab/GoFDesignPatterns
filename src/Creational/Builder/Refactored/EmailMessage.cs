namespace Builder.Refactored;
public class EmailMessage
{
    public string To { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public List<string> Cc { get; } = new();
    public List<string> Bcc { get; } = new();
    public List<string> Attachments { get; } = new();

    public void Send()
    {
        Console.WriteLine($"[Refactored] Sending email to {To} with subject: {Subject}");
    }
}
