using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_with_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMainMenu = true;


            while (showMainMenu)
            {
                showMainMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Welcome to Array Roulette! Select one of the options to see a different exercises. :)");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Array Information & Tips");
            Console.WriteLine("2) Insert an Element");
            Console.WriteLine("3) Delete an Element");
            Console.WriteLine("4) Sorting into Ascending Order");
            Console.WriteLine("5) Reversing an array");
            Console.WriteLine("6) Find min and max values");
            Console.WriteLine("7) Count duplicates");
            Console.WriteLine("8) Exit");


            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    // call function for array information
                    Console.WriteLine("hi");
                    return true;
                case "2":
                    InsertElement();
                    return true;
                case "3":
                    DeleteElement();
                    return true;
                case "4":
                    SortingElement();
                    return true;
                case "5":
                    ReverseArray();
                    return true;
                case "6":
                    MinandMaxElements();
                    return true;
                case "7":
                    DuplicateElements();
                    return true;
                case "8":
                    return false;
                default:
                    return true;
            }
        }

        private static void ArrayInformation()
        {

        }

        private static void InsertElement()
        {
            // creating the array to have five elements
            string[] insertArray = new string[5];

            Console.WriteLine("Please enter 1 value at a time to enter into the array");

            // for loop to add each element
            for(int i = 0; i < insertArray.Length; i++)
            {
                insertArray[i] = Console.ReadLine();

            }

            Console.WriteLine("");
            Console.Write("Here is your array: ");

            // I separated the first element of the list so that I can print a comma separating the following elements
            // without the comma being at the end of the last element. This makes it look nicer

            if (insertArray.Length >= 1)
            {
                Console.Write(insertArray[0]);
            }

            // prints each element added to the array
            for (int i = 1; i < insertArray.Length; i++)
            {
                Console.Write(","+ " "+ insertArray[i]);
            }

            Console.WriteLine("");
        }

        private static void DeleteElement()
        {
            // initilazing array and variables 
            string[] deleteArray = {"a", "b", "c", "d", "e", "f"};
            Random random = new Random();
            int minValue = deleteArray.Min(i => i.Length);
            int maxValue = deleteArray.Max(i => i.Length);

            Console.Write("Original Array: ");

            // printing array for the user to see before deletion process
            for (int i = 0; i < deleteArray.Length; i++)
            {
                Console.Write(deleteArray[i]);
                if (i < deleteArray.Length - 1)
                {
                    Console.Write(","+ " ");
                }
            }

            // adding sleep method to make it dramatic hehe
            Console.WriteLine("");
            Console.WriteLine("Deleting random element in 3...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1...");
            Console.WriteLine("");

            // select an element at random 
            var randomDelete = random.Next(deleteArray.Length);

            // tells the user which element is being deleted
            Console.WriteLine($"Deleted element: {deleteArray[randomDelete]}");

            // removes the element that was selected from randomDelete and makes the new array
            deleteArray = deleteArray.Where(e => e != deleteArray[randomDelete]).ToArray();

            Console.WriteLine("New Array: ");
            Console.WriteLine(String.Join(",", deleteArray)); // String.join concatenates the elements and separates them using commas 
            Console.WriteLine("");

        }
        private static void SortingElement()
        {
            int[] sortedArray = new int[] { 3, 1, 4, 5, 2 };

            Console.WriteLine("Original Array: "+ String.Join(",", sortedArray)); // String.join concatenates the elements and separates them using commas         
            Console.WriteLine("");

            // Sorting method
            Array.Sort<int>(sortedArray, new Comparison<int> ((a, b) => a.CompareTo(b)));
            
            Console.WriteLine("Sorted Array: " +String.Join(",", sortedArray)); // String.join concatenates the elements and separates them using commas         
            Console.WriteLine("");

        }

        private static void ReverseArray()
        {
            // initalizing variables and array
            int[] reverseArray = new int[] {};
            int size, i;

            // User input on size of array and scans next line
            Console.WriteLine("Please enter the desired size of your array: ");
            size = Convert.ToInt32(Console.ReadLine());

            // User can pick the elements in the array 
            Console.WriteLine("Enter elements in array: ");

            for (i = 0; i < size; i++)
            {
                reverseArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array in reverse order: ");

            for (i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(String.Join(",", reverseArray)); // String.join concatenates the elements and separates them using commas 
            }

            Console.ReadLine();
            Console.WriteLine("");

    }

        private static void MinandMaxElements()
        {


        }

        private static void DuplicateElements()
        {


        }

    }
}
