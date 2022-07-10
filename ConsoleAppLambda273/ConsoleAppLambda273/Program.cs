using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLambda273
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee { employeeID = 01, fname = "Walter", lname = "Jones" });
            employeeList.Add(new Employee { employeeID = 02, fname = "Diana", lname = "Bishop" });
            employeeList.Add(new Employee { employeeID = 03, fname = "Calvin", lname = "Kennedy" });
            employeeList.Add(new Employee { employeeID = 04, fname = "Joe", lname = "Davis" });
            employeeList.Add(new Employee { employeeID = 05, fname = "Brenda", lname = "Williamson" });
            employeeList.Add(new Employee { employeeID = 06, fname = "Katherine", lname = "Brown" });
            employeeList.Add(new Employee { employeeID = 07, fname = "Amy", lname = "White" });
            employeeList.Add(new Employee { employeeID = 08, fname = "Ashley", lname = "Cuevas" });
            employeeList.Add(new Employee { employeeID = 09, fname = "Darius", lname = "Dixon" });
            employeeList.Add(new Employee { employeeID = 10, fname = "Joe", lname = "White" });

            List<Employee> employeeJoes = new List<Employee>();
            
            int count = 0;
            foreach (Employee employee in employeeList)
            {
                if (employeeList[count].fname == "Joe")
                {
                    employeeJoes.Add(employee);
                }
                count++;
            }

            foreach (Employee employee in employeeList.FindAll(w => (w.fname == "Joe")).ToList())
            {
                employeeJoes.Add(employee);
            }

            var idList = employeeList.Where(x => (x.employeeID > 5)).ToList(); //Creation of new list by employee ID
            

            Console.WriteLine(employeeJoes.Count); //Adding to this list with all employees named Joe from both foreach loops
            Console.WriteLine(idList.Count);








            Console.ReadLine();
        }
    }
}
