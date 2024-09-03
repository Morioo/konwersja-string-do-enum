
using System;

namespace Lekcja13
{

    class Program
    {
        enum DaysOfWeek
        {
            Monday,
            tuesday,
            wendnesday,
            thursday,
            friday,
            saturday,
            sunday

        }

        static void Main(string[] args)
        {

            var day1 = "Monday";
            var day2 = "tueseday";
            var day3 = "Inny dzień";
            DaysOfWeek week1, week2, week3;
            if (Enum.TryParse< DaysOfWeek >(day1, out week1))
                Console.WriteLine("{0} converted to {1}", day1, week1);

            if (Enum.TryParse<DaysOfWeek>(day2, out week2))
                Console.WriteLine("{0} converted to {1}", day2, week2);




        }
    }
}