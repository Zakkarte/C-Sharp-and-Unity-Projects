using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParsingEnums262
{
    class Program
    {
        public enum Days
        {
            None,
            monday = 1,
            tuesday = 2,
            wednesday = 3,
            thursday = 4,
            friday = 5,
            saturday = 6,
            sunday = 7
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week:");
            string userDay = Console.ReadLine().ToLower();

            Days varDay;
            try
            {
                varDay = (Days)Enum.Parse(typeof(Days), userDay);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter an actual day of the week");


                varDay = Days.None;
            }

            if (varDay == Days.monday)
            {
                Console.WriteLine("You selected Monday");
            }
            if (varDay == Days.tuesday)
            {
                Console.WriteLine("You selected Tuesday");
            }
            if (varDay == Days.wednesday)
            {
                Console.WriteLine("You selected Wednesday");
            }
            if (varDay == Days.thursday)
            {
                Console.WriteLine("You selected Thursday");
            }
            if (varDay == Days.friday)
            {
                Console.WriteLine("You selected Friday");
            }
            if (varDay == Days.saturday)
            {
                Console.WriteLine("You selected Saturday");
            }
            if (varDay == Days.sunday)
            {
                Console.WriteLine("You selected Sunday");
            }
            Console.ReadLine();

        }

    }
}
