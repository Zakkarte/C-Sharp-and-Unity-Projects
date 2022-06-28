using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment1_6
{
    class Program
    
    {
        static void Main(string[] args)
        {   //Assignment 01 Begin
            Console.WriteLine("Assignment 01 Begin");
            Console.WriteLine("____________________________________________________________________");
            string[] stringArray = { "Dakota", "Jesse", "Adam", "Erik" };

            Console.WriteLine("Please write a last name");
            string userDefLName = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + " " + userDefLName;
            }

            foreach (string item in stringArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Assignment 01 End");
            Console.WriteLine("____________________________________________________________________");
            //Assignment 01 End
            //Assignemnt 02 Begin
            Console.WriteLine("Assignment 02 Begin");
            Console.WriteLine("____________________________________________________________________");
            int count = 0;

            while (true)
            {
                Console.WriteLine("Count = " + count);
                //Removing the count++ will create an infinate loop
                count++;

                if (count > 25)
                {
                    break;
                }
            }
            Console.WriteLine("Assignment 02 End");
            Console.WriteLine("____________________________________________________________________");
            //Assignment 02 End
            //Assignemnt 03 Begin
            Console.WriteLine("Assignment 03 Begin");
            Console.WriteLine("____________________________________________________________________");
            for (int j = 1; j < 5; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Assignment 03 Midpoint");
            Console.WriteLine("--------------------------------------------------------------------");
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Assignment 03 End");
            Console.WriteLine("____________________________________________________________________");
            //Assignment 03 End 
            //Assignment 04 Begin
            Console.WriteLine("Assignment 04 Begin");
            Console.WriteLine("____________________________________________________________________");

            List<string> addressList = new List<string>() { "Main", "First", "Second", "Third" };
            Console.WriteLine("Do you live on Main, First, Second, or Third Street?");
            string userSelectedAddress = Console.ReadLine();

            for (int i = 0; i < addressList.Count; i++)
            {
                if (!addressList.Contains(userSelectedAddress))
                {
                    Console.WriteLine("Not a viable answer");
                    break;
                }

                else if (userSelectedAddress == addressList[i])
                {
                    Console.WriteLine(i);
                    break; // will stop getting indexcies as it terminates the iteration <--- in loop
                }

            }

            Console.WriteLine("Assignment 04 End");
            Console.WriteLine("____________________________________________________________________");
            //Assignment 04 End
            //Assignment 05 Begin
            Console.WriteLine("Assignment 05 Begin");
            Console.WriteLine("____________________________________________________________________");
            List<string> studentNames = new List<string>() { "Joe", "Joe", "Tim", "Paul", "Joe" };        
            Console.WriteLine("What is your childs name?");
            string userStudentNameSelected = Console.ReadLine();

            for (int i = 0; i < studentNames.Count; i++)
            {
                if (!studentNames.Contains(userStudentNameSelected))
                {
                    Console.WriteLine("Not a viable answer");
                    break;
                }

                else if (userStudentNameSelected == studentNames[i])
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine("Assignment 05 End");
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("Assignment 06 Begin");
            Console.WriteLine("____________________________________________________________________");
            
            List<string> studentNames1 = new List<string>() { "Joe", "Joe", "Tim", "Paul" };
            List<string> studentNamesMulti = new List<string>();

            foreach (string studentname in studentNames1)
            {
                if (studentNamesMulti.Contains(studentname))
                {
                    Console.WriteLine("This has appeared in the list before " + studentname);
                }
                else
                {
                    Console.WriteLine("This has not appeared in the list yet " + studentname);
                    studentNamesMulti.Add(studentname);
                }
            }

            Console.WriteLine("Assignment 06 End");
            Console.WriteLine("____________________________________________________________________");

            Console.ReadLine();
                 
        }
    }
}
