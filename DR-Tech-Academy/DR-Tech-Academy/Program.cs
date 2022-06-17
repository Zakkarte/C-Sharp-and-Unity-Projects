using System;

namespace DR_Tech_Academy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to The Tech Academys");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you taking:");
            string coursename = Console.ReadLine();
            Console.WriteLine("What page number are you one:");
            int pagenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.“");
            bool needhelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string expshared = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string optfeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // Console.WriteLine("Hello, " + name + coursename + pagenumber + needhelp + expshared + optfeedback + "!");
            
            Console.Read();
        }
    }
}
