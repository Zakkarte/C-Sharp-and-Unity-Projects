using System;


namespace BoolPractice
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("What is your age?:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have your ever had a DUI? Answer in true or false.");
            bool DUItruefalse = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets have you recieved?:");
            int ticketammount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            bool isQualified = age > 15 && DUItruefalse == false && ticketammount < 3;
            Console.WriteLine(isQualified);

            Console.ReadLine();


        }
    }
}
