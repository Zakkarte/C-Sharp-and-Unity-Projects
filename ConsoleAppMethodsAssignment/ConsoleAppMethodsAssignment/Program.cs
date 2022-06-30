using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            var userValue = Convert.ToInt32(Console.ReadLine());

            var mathsObject = new maths();
            var resultAdd = mathsObject.Add(userValue);
            var resultSub = mathsObject.Subtract(userValue);
            var resultDivide = mathsObject.Divide(userValue);

            Console.WriteLine("-------------");
            Console.WriteLine(userValue + " + 50 = " + resultAdd);
            Console.WriteLine("-------------");
            Console.WriteLine(userValue + " - 10 = " + resultSub);
            Console.WriteLine("-------------");
            Console.WriteLine(userValue + " / 2 = " + resultDivide);
            Console.WriteLine("-------------");

            Console.ReadLine();




        }
    }
}
