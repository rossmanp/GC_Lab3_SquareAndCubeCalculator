using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pete Rossman
//GC .NET Bootcamp Lab 3
//March 29, 2017

namespace GC_Lab3_SquareAndCubeCalculator
{
    class Program
    {
        //This program takes an integer as intput
        //and outputs a list of numbers with their squares and cubes
        //up to the number input.

        static void Main(string[] args)
        {
            Boolean run = true;
            int myInt;
            Console.WriteLine("Learn your squares and cubes!");
            while (run)
            {
                Console.Write("\nEnter an integer: ");                              
                int.TryParse(Console.ReadLine(), out myInt);
                Console.Write("\n");
                Console.WriteLine("Number \tSquared  Cubed");
                Console.WriteLine("====== \t=======  =====");
                WriteOutput(myInt);
                run = Continue();
            }
            Console.ReadLine();
        }

        //The square and cube methods are used to square and cube numbers.

        public static int Square(int num) => num * num;

        public static int Cube(int num) => num * num * num;

        //The WriteOutput method prints numbers along with
        //their squares and cubes up to the input.

        public static void WriteOutput(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i + "\t" + Square(i) + "\t " + Cube(i));
            }
        }

        //The Continue method runs the program again if the user wants
        //or allows the user to exit.

        public static Boolean Continue()
        {
            Console.Write("\nContinue? (Y/N): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input = input.ToLower();
            if (input == "n")
            {
                Console.WriteLine("\nGoodbye!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }
            return run;
        }
    }
}
