using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Dakota", "Jesse", "Marco", "Don" };

            Console.WriteLine("Please select a number through 0-3:");
            int stringSelection = Convert.ToInt32(Console.ReadLine());
            if (stringSelection < 4)
            {
                Console.WriteLine(stringArray[stringSelection]);
            }
            else
            {
                Console.WriteLine("Do you not know how to read?");
                
            }
            

            int[] intArray = { 10, 100, 1000, 10000 };

            Console.WriteLine("Please select a number through 0-3:");
            int intSelection = Convert.ToInt32(Console.ReadLine());
            if (intSelection < 4)
            {
                Console.WriteLine(intArray[intSelection]);
            }
            else 
            {
                Console.WriteLine("Uhhhh.... you are making this way harder than it needs to be");
            }

            List<string> stringList = new List<string>();

            stringList.Add("100$");
            stringList.Add("0$");
            stringList.Add("1000000$");

            Console.WriteLine("Please select a number through 0-2");
            int stringListSelection = Convert.ToInt32(Console.ReadLine());
            if (stringListSelection < 4)
            {
                Console.WriteLine(stringList[stringListSelection]);
            }
            else
            {
                Console.WriteLine("I do not want to live on this planet anymore...");

            }


            Console.Read();
        }
    }
}
