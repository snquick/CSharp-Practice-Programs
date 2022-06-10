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
            //Console.Clear();
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
                    // sorting
                    return true;
                case "5":
                    // reverse
                    return true;
                case "6":
                    // min and max 
                    return true;
                case "7":
                    // duplicates
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

        }

        private static void DeleteElement()
        {

        }
    }
}
