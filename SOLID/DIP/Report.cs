namespace DIP
{
    public interface ISender
    {
        void Send(string to);
    }
    public class MailSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine($"Mail, {to} adresine gönderildi");
        }
    }
    public class Report
    {
        ISender sender;

        public Report(ISender sender)
        {
            this.sender = sender;
        }

        public void SendReport(string to)
        {

            sender.Send(to);

        }
    }


    public class WhatsAppSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine($"Mail, {to} adresine WhatsApp ile gönderildi");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine($"Mail, {to} adresine Telegram ile gönderildi");
        }
    }
}
