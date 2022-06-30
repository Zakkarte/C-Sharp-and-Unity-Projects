using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodAssignment
{
    public class Maths
    {
        public int Add(int data, int value)
        {
            return data + value;
        }

        public int decSub(decimal data, int value)
        {
            return (Convert.ToInt32(data)) - value;
        }

        public string stringCon(string data, int value)
        {
            return data + value;
        }
    }
}
