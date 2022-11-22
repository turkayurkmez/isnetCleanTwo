namespace TimeSheetLibrary
{
    public class TimeSheetProcessor
    {
        public double GetTotalAmountForCompany(List<TimeSheetEntry> timeSheetEntries, string companyName)
        {
            double totalAmount = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.ToLower().Contains(companyName))
                {
                    totalAmount += timeSheetEntries[i].HoursWorked;
                }
            }

            return totalAmount;
        }
        public double TotalWorkedHours(List<TimeSheetEntry> timeSheetEntries)
        {
            double total = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                total += timeSheetEntries[i].HoursWorked;
            }
            return total;
        }

        public void ExtraWorkinhHourPayment(List<TimeSheetEntry> timeSheetEntries, int maximumWorkehHour, double extraPayment, double standartPayment)
        {
            var totalWorkHours = TotalWorkedHours(timeSheetEntries);
            if (totalWorkHours > maximumWorkehHour)
            {
                Console.WriteLine("You will get paid $" + (((totalWorkHours - maximumWorkehHour) * extraPayment) + (maximumWorkehHour * standartPayment)) + " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + totalWorkHours * standartPayment + " for your time.");
            }
        }
    }
}
