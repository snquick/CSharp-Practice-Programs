using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initializing variables
            int num1, num2, sum;

            // First number
            Console.WriteLine("Please enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Second number
            Console.WriteLine("Please enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // calculating total
            sum = num1 + num2;
            Console.WriteLine("Here is the sum: " + sum);

            Console.WriteLine("Please press <q> to exit the program...");

            // The ReadKey method will wait until the "q" button is clicked before closing out of the application
            while (Console.ReadKey().Key != ConsoleKey.Q) { }

        


        }
    }
}
