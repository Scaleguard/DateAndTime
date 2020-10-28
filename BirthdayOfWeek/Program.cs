using System;

namespace BirthdayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //the appliaction asks the users date of birth
            //and displays the day of the week ther user was born on.
            
            Console.WriteLine("Enter your year of birth");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your month of Birth");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your date of birth");
            int day = Int32.Parse(Console.ReadLine());

            GetTheWeekDay(year, month, day);

        }

        public static void GetTheWeekDay(int year, int month, int date)
        {
            DateTime birthdate = new DateTime(year, month, date);
            var DayOfTheWeek = birthdate.DayOfWeek;
            Console.WriteLine($"You were born on {DayOfTheWeek}");
        }
    }
}
