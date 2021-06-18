using System;
using System.Collections.Generic;
namespace MethodOverloadingPractice
{
    class Program
    {
        //TODO Create a method that takes two string names in the parameter. Have the method tell you which name is longer.
        public static void NameLength(string nameOne, string nameTwo)
        {
            int firstlength = nameOne.Length;
            int secondlength = nameTwo.Length;

            if (firstlength > secondlength)
            {
                Console.WriteLine($"{nameOne} is larger in length than {nameTwo}.");
            }
            else
            {
                Console.WriteLine($"{nameTwo} is larger in length than {nameOne}.");
            }
        }

        //TODO Create an overload method that takes a list of string names and an integer. The method will look for the first name that matches the length of the integer.
        public static void NameLength(List<string> names, int number)
        {
            int notFound = 0;
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Length == number)
                {
                    Console.WriteLine($"{names[i]} is the first name in your list with a length of {number}.");
                    break;
                }
                else
                {
                    notFound = i;
                }
            }
            if (notFound == names.Count - 1)
            {
                Console.WriteLine($"Your list does not contain a name with a length of {number}");
            }
        }

        static void Main(string[] args)
        {
            
            //TODO Call both methods here. Use a break point and watch as the code jumps to the different method overloads.

            //Method 1 example
            Console.WriteLine("Please enter two names and I will tell you which one is longer:");
            string userName = Console.ReadLine();
            string userNameTwo = Console.ReadLine();
            NameLength(userName, userNameTwo);

            //Method 2 example
            Console.WriteLine("Please enter a list of five names:");
            List<string> userNames = new List<string>(); 
            for (int i = 0; i < 5; i++)
            {
                userNames.Add(Console.ReadLine());
            }
            Console.WriteLine("Thank you. Now I will find the first name in your list that has a given length. Please enter a length you would like to use: ");
            int nameLength = int.Parse(Console.ReadLine());
            NameLength(userNames, nameLength);

        } 
        
     
    }
}
