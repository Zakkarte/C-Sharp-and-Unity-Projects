using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodsObjects231
{
    class Program
    {
        static void Main(string[] args)
        {
            var methodObject = new Employee();
            methodObject.FirstName = "Dakota";
            methodObject.LastName = "Kent";

            methodObject.SayName();
            Console.Read();

        }
    }
}
