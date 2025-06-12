namespace Builder.Refactored;
public class EmailMessageBuilder : IEmailMessageBuilder
{
    private readonly EmailMessage _message = new EmailMessage();

    public IEmailMessageBuilder To(string to)
    {
        _message.To = to;
        return this;
    }

    public IEmailMessageBuilder Subject(string subject)
    {
        _message.Subject = subject;
        return this;
    }

    public IEmailMessageBuilder Body(string body)
    {
        _message.Body = body;
        return this;
    }

    public IEmailMessageBuilder AddCc(string cc)
    {
        _message.Cc.Add(cc);
        return this;
    }

    public IEmailMessageBuilder AddBcc(string bcc)
    {
        _message.Bcc.Add(bcc);
        return this;
    }

    public IEmailMessageBuilder AddAttachment(string file)
    {
        _message.Attachments.Add(file);
        return this;
    }

    public EmailMessage Build() => _message;
}
