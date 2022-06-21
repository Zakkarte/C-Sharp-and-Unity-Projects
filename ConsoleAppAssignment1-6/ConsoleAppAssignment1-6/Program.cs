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
            List<string> userDefAddressList = new List<string>();
            Console.WriteLine("Do you live on Main, First, Second, or Third Street?");
            string userSelectedAddress = Console.ReadLine();
            foreach (string address in addressList)
            {
                if (address == userSelectedAddress)
                {
                    userDefAddressList.Add(address);
                    Console.WriteLine(userDefAddressList.Count);
                    break;
                }
                else if (address != userSelectedAddress)
                {
                    Console.WriteLine("You have entered an address that is not on the List");
                    break;
                }
                
            }
            Console.WriteLine("Assignment 04 End");
            Console.WriteLine("____________________________________________________________________");
            //Assignment 04 End
            //Assignment 05 Begin
            Console.WriteLine("Assignment 05 Begin");
            Console.WriteLine("____________________________________________________________________");
            List<string> studentNames = new List<string>() { "Joe", "Joe", "Tim", "Paul" };        
            Console.WriteLine("What is your childs name?");
            string userStudentNameSelected = Console.ReadLine();
            foreach (string studentname in studentNames)
            {
                if (userStudentNameSelected == studentname)
                {
                    Console.WriteLine(studentname.Count());
                    break;
                }
                else if (userStudentNameSelected != studentname)
                {
                    Console.WriteLine("You didn't input a valid Student Name");
                    break;
                }
            }

            Console.WriteLine("Assignment 05 End");
            Console.WriteLine("____________________________________________________________________");
            // I have no idea how to perform what is asked in the instructions
            //Assignment 05 End
            List<string> studentNames1 = new List<string>() { "Joe", "Joe", "Tim", "Paul" };
            foreach (string studentname in studentNames1)
            {
                Console.WriteLine(studentname);
                if (studentname == studentname)
                {
                    Console.WriteLine("Has already been displayed");
                }
            }









            Console.ReadLine();
            
                    
                
        }
    }
}
