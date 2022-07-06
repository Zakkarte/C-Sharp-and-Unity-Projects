using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodAssignment
{
    public class Maths
    {
        public int Method(int data, int value)
        {
            return data + value;
        }

        public int Method(decimal data, int value)
        {
            return (Convert.ToInt32(data)) - value;
        }

        public string Method(string data, int value)
        {
            return data + value;
        }
    }
}
