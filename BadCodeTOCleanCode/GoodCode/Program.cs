using NotificationManager;
using TimeSheetLibrary;

namespace GoodCode
{
    class Program
    {

        static TimeSheetProcessor timeSheetProcessor = new TimeSheetProcessor();
        static void Main(string[] args)
        {
            var timeSheetEntries = LoadEntries();
            MailSender mailSender = new MailSender();
            mailSender.SendMailToCompany(timeSheetEntries, "acme", 150);
            mailSender.SendMailToCompany(timeSheetEntries, "ABC", 125);

            timeSheetProcessor.ExtraWorkinhHourPayment(timeSheetEntries, maximumWorkehHour: 40, extraPayment: 15, standartPayment: 10);

            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }



        static List<TimeSheetEntry> LoadEntries()
        {
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            string userAnswerForContinuing = string.Empty;
            do
            {
                double workedTime = 0;

                Console.Write("Enter what you did: ");
                string workDescription = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                string rawTimeWorked = Console.ReadLine();

                workedTime = getDoubleValueFromString(rawTimeWorked);

                TimeSheetEntry timeSheetEntry = new TimeSheetEntry();
                timeSheetEntry.HoursWorked = workedTime;
                timeSheetEntry.WorkDone = workDescription;
                timeSheetEntries.Add(timeSheetEntry);

                Console.Write("Do you want to enter more time (yes/no): ");
                userAnswerForContinuing = Console.ReadLine();

            } while (userAnswerForContinuing.ToLower() == "yes");

            return timeSheetEntries;

        }

        private static double getDoubleValueFromString(string rawTimeWorked)
        {
            double workedTime;
            while (double.TryParse(rawTimeWorked, out workedTime) == false)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number given");
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();
            }

            return workedTime;
        }
    }


}