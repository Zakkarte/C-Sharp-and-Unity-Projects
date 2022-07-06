using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass224
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathsObject = new maths(); //instantiate
            Console.WriteLine("Please enter a number:");
            var userInput = Console.ReadLine();
            int userResult;
            mathsObject.Halve(int.Parse(userInput), out userResult);

            Console.WriteLine(userInput + " halved is : " + userResult);

            mathsObject.method(2, 2);
            mathsObject.method(2, 2, 2);
            
            var arithmaResult = arithma.sum(1, 1);

            Console.WriteLine(arithmaResult);

            Console.Read();
            
        }
    }
}
