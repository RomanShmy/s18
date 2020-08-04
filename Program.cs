using System.Data.SqlTypes;
using System.Linq;
using System;
using static System.Console;

namespace hello_console
{
    public struct PeriodRange
    {
        public DateTime Start {get; set;}
        public DateTime End {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
           DateTime[] holidays = {new DateTime(2020, 8, 24)};
           DateTime start = new DateTime(2020, 8, 5);
           DateTime end = new DateTime(2020, 8, 26);
           WriteLine($"Count of working days: {CountWorkingDays(start, end, holidays)}, without structure.");
           PeriodRange range = new PeriodRange{Start = new DateTime(2020, 8, 5), End = new DateTime(2020, 8, 26)};
           WriteLine($"Count of working days: {CountWorkingDays(range, holidays)}, with structure.");
        }

        static int CountWorkingDays(DateTime start, DateTime end, DateTime[] holidays = null)
        {
            int CountDay = Int32.Parse((end - start).TotalDays.ToString());
            for (DateTime i = start.Date; i <= end.Date; i = i.AddDays(1) )
            {
                if (holidays.Contains(i)){
                    CountDay--;
                }
            }
            
            return CountDay;
        }

        static int CountWorkingDays(PeriodRange period, DateTime[] holidays = null)
        {
            return CountWorkingDays(period.Start, period.End, holidays);
        }
    }
}
