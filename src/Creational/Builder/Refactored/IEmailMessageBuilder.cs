namespace Builder.Refactored;
public interface IEmailMessageBuilder
{
    public IEmailMessageBuilder To(string to);
    public IEmailMessageBuilder Subject(string subject);
    public IEmailMessageBuilder Body(string body);
    public IEmailMessageBuilder AddCc(string cc);
    public IEmailMessageBuilder AddBcc(string bcc);
    public IEmailMessageBuilder AddAttachment(string file);
    public EmailMessage Build();
}
