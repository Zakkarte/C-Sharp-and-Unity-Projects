using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an number");
            var userValue = Convert.ToInt32(Console.ReadLine());

            var mathsObject = new Maths();
            int resultAdd = mathsObject.Method(userValue);
            Console.WriteLine(userValue + " + 50 = " + resultAdd);
            Console.WriteLine("-------------");
            Console.WriteLine("Please input a number as decimal");
            decimal decUserValue = Convert.ToDecimal(Console.ReadLine());

            int resultDecSub = mathsObject.Method(decUserValue);
            Console.WriteLine(decUserValue + " - 10 = " + resultDecSub);
            Console.WriteLine("-------------");

            Console.WriteLine("Please input a string of text that will be added to an int");
            string stringValue = (Console.ReadLine());

            int restulString = mathsObject.Method(stringValue);
            Console.WriteLine(stringValue + " + 200 :" + restulString);


            Console.ReadLine();

        }
    }
}
