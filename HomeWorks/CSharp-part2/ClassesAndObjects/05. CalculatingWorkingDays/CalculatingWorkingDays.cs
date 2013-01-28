using System;

public class NumberOfWorkDays
{
    public static void Main()
    {
        Console.WriteLine("Enter a end date in YYYY/MM/DD format");
        string[] endDate = Console.ReadLine().Split('/');
        int year = int.Parse(endDate[0]);
        int month = int.Parse(endDate[1]);
        int day = int.Parse(endDate[2]);

        DateTime startDay = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);
        int timePeriod = 0;
        timePeriod = Math.Abs((endDay - startDay).Days);
        if (startDay > endDay)
        {
            startDay = endDay;
            endDay = DateTime.Today;
        }

        DateTime[] holidays =
        {
                new DateTime(currYear, 1, 1),
                new DateTime(currYear, 3, 3),
                new DateTime(currYear, 5, 1),
                new DateTime(currYear, 5, 2),
                new DateTime(currYear, 5, 6),
                new DateTime(currYear, 5, 24),
                new DateTime(currYear, 9, 22),
                new DateTime(currYear, 12, 24),
                new DateTime(currYear, 12, 25),
                new DateTime(currYear, 12, 26),
                new DateTime(currYear, 12, 31)
        };
        Console.WriteLine(timePeriod);
        int workDayCounter = 0;
        bool isHoliday = false;

        // Day checker
        for (int i = 0; i < timePeriod; i++)
        {
            startDay = startDay.AddDays(1);
            if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDay == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDayCounter++;
                }

                isHoliday = false;
            }
        }

        Console.WriteLine(workDayCounter);
    }
}