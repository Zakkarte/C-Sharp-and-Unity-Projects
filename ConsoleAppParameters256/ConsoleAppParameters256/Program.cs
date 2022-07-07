using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParameters256
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeString = new Employee<string>();
            employeeString.things = new List<string>();

            employeeString.things.Add("Jesse");
            employeeString.things.Add("Joe");
            employeeString.things.Add("Bob");

            Employee<int> employeeInt = new Employee<int>();
            employeeInt.things = new List<int>();

            employeeInt.things.Add(1093);
            employeeInt.things.Add(123023);
            employeeInt.things.Add(51);

            foreach (string thing in employeeString.things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("---------------------");
            foreach (int thing in employeeInt.things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

        }
    }
}
