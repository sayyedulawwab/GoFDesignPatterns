namespace Visitor.Bad;
public class NotificationProcessor
{
    public void Log(object notification)
    {
        if (notification is EmailNotification email)
        {
            Console.WriteLine($"Logging Email to {email.Email}: {email.Message}");
        }
        else if (notification is SMSNotification sms)
        {
            Console.WriteLine($"Logging SMS to {sms.PhoneNumber}: {sms.Message}");
        }
        else if (notification is PushNotification push)
        {
            Console.WriteLine($"Logging Push to {push.DeviceId}: {push.Message}");
        }
    }

    public void Send(object notification)
    {
        if (notification is EmailNotification email)
        {
            Console.WriteLine($"Sending Email to {email.Email}: {email.Message}");
        }
        else if (notification is SMSNotification sms)
        {
            Console.WriteLine($"Sending SMS to {sms.PhoneNumber}: {sms.Message}");
        }
        else if (notification is PushNotification push)
        {
            Console.WriteLine($"Sending Push to {push.DeviceId}: {push.Message}");
        }
    }

    public void Audit(object notification)
    {
        if (notification is EmailNotification email)
        {
            Console.WriteLine($"Auditing Email: {email.Email}");
        }
        else if (notification is SMSNotification sms)
        {
            Console.WriteLine($"Auditing SMS: {sms.PhoneNumber}");
        }
        else if (notification is PushNotification push)
        {
            Console.WriteLine($"Auditing Push: {push.DeviceId}");
        }
    }
}
