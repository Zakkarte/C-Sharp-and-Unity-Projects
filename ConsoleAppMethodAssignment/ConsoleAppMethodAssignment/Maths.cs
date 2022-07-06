using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethodAssignment
{
    public class Maths
    {
        public int Method(int data)
        {
            int result;
            result = data + 50;
            return result;

        }

        public int Method(decimal data)
        {
            int result2;
            result2 = Convert.ToInt32(data) - 10;
            return result2;
        }

        public int Method(string data)
        {
            int dataConvert = Convert.ToInt32(data);
            int result3 = dataConvert + 200;

            return result3;
        }
    }
}
