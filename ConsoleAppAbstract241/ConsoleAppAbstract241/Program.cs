using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstract241
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();

            IQuittable quittable = new Employee();
            quittable.Quit();
            employee.Quit();

            Console.ReadLine();

        }
    }
}
