using System;


namespace MathCompAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate:");
            decimal p1_hourRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week:");
            int p1_hourWeek = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate:");
            decimal p2_hourRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week:");
            int p2_hourWeek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            decimal p1_salary = Convert.ToDecimal(p1_hourRate * p1_hourWeek * 52);
            Console.WriteLine(p1_salary + "$");

            Console.WriteLine("Annual salary of Person 2:");
            decimal p2_salary = Convert.ToDecimal(p2_hourRate * p2_hourWeek * 52);
            Console.WriteLine(p2_salary + "$");

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isTrueorFalse = p1_salary > p2_salary;
            Console.WriteLine(isTrueorFalse);
            Console.ReadLine();
        }
    }
}
