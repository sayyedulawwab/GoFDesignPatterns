namespace Prototype.Refactored;
public class EmailTemplate : IPrototype<EmailTemplate>
{
    public string Subject { get; set; }
    public string Body { get; set; }
    public List<string> Tags { get; set; }

    public EmailTemplate(string subject, string body, List<string> tags)
    {
        Subject = subject;
        Body = body;
        Tags = tags;
    }

    public EmailTemplate Clone()
    {
        return new EmailTemplate(Subject, Body, new List<string>(Tags));
    }
}
