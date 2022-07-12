using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppDateTime307
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time1 = DateTime.Now;
            Console.WriteLine(time1);
            
            Console.WriteLine("Please type out a number:");
            int answer = Convert.ToInt32(Console.ReadLine());
            DateTime time2 = time1.AddHours(answer);
            Console.WriteLine(time2);
            Console.Read();
        }
    }
}
