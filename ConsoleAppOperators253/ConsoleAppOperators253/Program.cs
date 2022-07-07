using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperators253
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jesse = new Employee(1, "Jesse");
            var Joe = new Employee(2, "Joe");
            var JesseDup = new Employee(1, "JesseDup");

            Console.WriteLine(Jesse._EmployeeName + " and " + Joe._EmployeeName + " share the same ID: " + Jesse._EmployeeID.Equals(Joe._EmployeeID));
            Console.WriteLine(Jesse._EmployeeName + " and " + Joe._EmployeeName + " share the same ID: " + (Jesse._EmployeeID == Joe._EmployeeID));
            Console.WriteLine(Jesse._EmployeeName + " and " + JesseDup._EmployeeName + " Share the same ID: " + Jesse._EmployeeID.Equals(JesseDup._EmployeeID) + "\n" + "But do they share the same name: " + Jesse._EmployeeName.Equals(JesseDup._EmployeeName));


            Console.ReadLine();
        }
    }
}
