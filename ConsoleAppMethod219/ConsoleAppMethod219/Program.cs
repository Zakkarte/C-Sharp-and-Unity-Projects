using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethod219
{
    class Program
    {

        static void Main(string[] args)

        {
            var mathsObject = new Maths();
            Console.WriteLine("Please enter a number:");
            int userValue = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter a second number or leave blank for default 10");
            var userResponse=Console.ReadLine();

            int result;

            if (userResponse == "")
            {
                 result = mathsObject.Add(userValue);
                Console.WriteLine("You are using the default value");
            }
            else
            {
                 result = mathsObject.Add(userValue, Convert.ToInt32(userResponse));
            }

            Console.WriteLine(userValue + userResponse + " + " + result);

            Console.Read();






        }

    }
}
