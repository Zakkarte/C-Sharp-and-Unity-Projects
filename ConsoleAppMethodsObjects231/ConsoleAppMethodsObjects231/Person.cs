using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodsObjects231
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            var FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + FullName);

        }
    }
}
