// See https://aka.ms/new-console-template for more information
using DIP;

Console.WriteLine("Hello, World!");


MailSender mailSender = new MailSender();
WhatsAppSender whatsAppSender = new WhatsAppSender();
TelegramSender telegramSender = new TelegramSender();

Report report = new Report(telegramSender);
report.SendReport("türkay");
