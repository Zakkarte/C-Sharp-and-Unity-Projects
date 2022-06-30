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
            int resultAdd = mathsObject.Add(userValue, 50);
            Console.WriteLine(userValue + " + 50 = " + resultAdd);
            Console.WriteLine("-------------");
            Console.WriteLine("Please input a number as decimal");
            var decUserValue = Convert.ToDecimal(Console.ReadLine());

            int resultDecSub = mathsObject.decSub(decUserValue, 10);
            Console.WriteLine(decUserValue + " - 10 = " + resultDecSub);
            Console.WriteLine("-------------");

            Console.WriteLine("Please input a string of text that will be added to an int");
            string stringValue = (Console.ReadLine());

            var restulString = mathsObject.stringCon(stringValue, 200);
            Console.WriteLine(stringValue + " + 200 :" + restulString);


            Console.ReadLine();

        }
    }
}
