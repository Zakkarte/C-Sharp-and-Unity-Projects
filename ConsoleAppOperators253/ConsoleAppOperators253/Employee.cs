using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperators253
{
    public class Employee
    {
        public int _EmployeeID { get; set; }
        public string _EmployeeName { get; set; }

        public Employee(int EmployeeID, string EmployeeName)
        {
            _EmployeeID = EmployeeID;
            _EmployeeName = EmployeeName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (GetType() != obj.GetType())
            {
                return false;
            }

            var employee1 = (Employee)obj;
            return (_EmployeeID == employee1._EmployeeID) && (_EmployeeName == employee1._EmployeeName);

        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }


        public static bool operator == (Employee a, Employee b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static bool operator !=(Employee a, Employee b)
        {
            if (a.Equals(b))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
