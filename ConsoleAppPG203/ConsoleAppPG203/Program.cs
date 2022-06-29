using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPG203
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                List<int> intList = new List<int>() { 4, 28, 34, 16, 98 };
                Console.WriteLine("Please select a number to use in division :");
                int userInt = Convert.ToInt32(Console.ReadLine());
                

                for (int i = 0; i < intList.Count; i++)
                {
                    Console.WriteLine(intList[i] + " Divided by " + userInt + " Equals = " + intList[i] / userInt);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Common... you know what you did.");
            }
            catch (FormatException ex)
            {
                
                Console.WriteLine("You know you cant divide meow by a number.... if this is the first time you are hearing this...");
            }
            Console.Read();
        }
    }
}
