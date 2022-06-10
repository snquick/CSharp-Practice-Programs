using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initalizing variables
            int num1, num2, temp;
            
            // welcome text
            Console.WriteLine("***Welcome to swap your numbers corporation! If you need two numbers swapped, you came to the right place***");

            // user input and scanning the values
            Console.WriteLine("Enter the first number please: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number please: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // values of the two variables are being swapped with each other without creating new storage location for the variables
            temp = num1;

            num1 = num2;
            num2 = temp;

            Console.WriteLine("Here is the swapped value for Number 1: "+ num1);
            Console.WriteLine("Here is the swapped value for Number 2: " + num2);
            Console.WriteLine("");

            // Quitting program
            Console.WriteLine("Please press <q> to exit the program...");
            while (Console.ReadKey().Key != ConsoleKey.Q) { }

        }
    }
}
