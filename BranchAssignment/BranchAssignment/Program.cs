using System;


namespace BranchAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Planet Express. Plese follow the instructions below.");
            Console.WriteLine("What is the weight of the package?");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the width of the package?");
            int packWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the package?");
            int packHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of the package?");
            int packLength = Convert.ToInt32(Console.ReadLine());

            int totalDimensions = packHeight + packLength + packWidth;
            int quoteCal = (packHeight * packLength * packWidth * packWeight) / 100;
           
            string results = totalDimensions > 50 ? "Package too big to be shipped via Planet Express." : "Your estimated total for shipping this package is: $" + Convert.ToString(quoteCal) ;

            Console.WriteLine(results);

            Console.WriteLine("Thank you! We know you had other options to ship this package. And you made the wrong choice");
            
            Console.ReadLine();
        }
    }
}
