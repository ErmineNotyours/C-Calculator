using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* *
 * C# Calculator
 * By Arthur Allen
 * Using menu structure code from the Microsoft Virtual Adademy While Iteration Statement section
 * */

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Persist the main menu

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

            MainMenu();
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("q) Quit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Addition();
                return true;
            }
            else if (result == "2")
            {
                Subtraction();
                return true;
            }
            else if (result == "3")
            {
                Multiplication();
                return true;
            }
            else if (result == "4")
            {
                Division();
                return true;
            }
            else if ((result == "q") || (result == "Q"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void Addition()
        {
            Console.Clear();
            Console.WriteLine("Addition");
            Console.Write("Type a number to add: ");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.Write("Type the next number to add: ");
            decimal y = decimal.Parse(Console.ReadLine());
            decimal result = x + y;
            Console.Write("{0} + {1} = {2} ", x, y, result);
            Console.ReadLine();
        }

        private static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Subtraction");
            Console.Write("Type a number to subtract: ");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.Write("Type the next number to subtract: ");
            decimal y = decimal.Parse(Console.ReadLine());
            decimal result = x - y;
            Console.Write("{0} - {1} = {2} ", x, y, result);
            Console.ReadLine();
        }

        private static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Multiplication");
            Console.Write("Type a number to multiply: ");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.Write("Type the next number to multiply: ");
            decimal y = decimal.Parse(Console.ReadLine());
            decimal result = x * y;
            Console.Write("{0} * {1} = {2} ", x, y, result);
            Console.ReadLine();
        }

        private static void Division()
        {
            Console.Clear();
            Console.WriteLine("Division");
            Console.Write("Type a number to divide: ");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.Write("Type the next number to divide: ");
            decimal y = decimal.Parse(Console.ReadLine());
            if (y != 0)  // Check for division by zero
            {
                decimal result = x / y;
                Console.Write("{0} / {1} = {2} ", x, y, result);
                Console.ReadLine();
            }
            else
            {
                Console.Write("You can't divide by zero! ");
                Console.ReadLine();
            }
        }
    }
}
