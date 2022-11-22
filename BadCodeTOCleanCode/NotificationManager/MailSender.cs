using TimeSheetLibrary;

namespace NotificationManager
{
    public class MailSender
    {
        public void SendMailToCompany(List<TimeSheetEntry> timeSheetEntries, string company, double hourlyRate)
        {
            TimeSheetProcessor timeSheetProcessor = new TimeSheetProcessor();
            var totalAmount = timeSheetProcessor.GetTotalAmountForCompany(timeSheetEntries, company);
            Console.WriteLine("Simulating Sending email to " + company);
            Console.WriteLine("Your bill is $" + totalAmount * hourlyRate + " for the hours worked.");
        }
    }
}