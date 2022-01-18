using System;

namespace Palindrome_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: "); //Asks the user to enter a string.
            string userString = Console.ReadLine().ToLower(); //Inputs and converts the string to all lowercase so it isn't case sensitive.


            int i = 0;
            int j = userString.Length - 1;


            while (true) //Continuously loops the following code.
            {
                char a = userString[i];
                char b = userString[j];

                if (a != b) //Checks if the characters are not the same.
                {
                    Console.WriteLine($"{userString} is not a palindrome.");
                    break;
                }
                else if (i >= j) //Checks if the ehile loop has gone through every letter.
                {
                    Console.WriteLine($"{userString} is a palindrome.");
                    break;
                }
                i++;
                j--;
            }
        }
    }
}