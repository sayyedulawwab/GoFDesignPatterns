namespace Builder.Bad;
public class EmailMessage
{
    public string To { get; }
    public string Subject { get; }
    public string Body { get; }
    public List<string> Cc { get; }
    public List<string> Bcc { get; }
    public List<string> Attachments { get; }

    public EmailMessage(
        string to,
        string subject,
        string body,
        List<string>? cc = null,
        List<string>? bcc = null,
        List<string>? attachments = null)
    {
        To = to;
        Subject = subject;
        Body = body;
        Cc = cc ?? new();
        Bcc = bcc ?? new();
        Attachments = attachments ?? new();
    }

    public void Send()
    {
        Console.WriteLine($"[Bad] Sending email to {To} with subject: {Subject}");
    }
}
