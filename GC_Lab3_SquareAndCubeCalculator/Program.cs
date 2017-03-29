using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab3_SquareAndCubeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine("");
            Console.Write("Enter an integer: ");
            Console.WriteLine("");
            int.TryParse(Console.ReadLine(), out myInt);
            Console.WriteLine("Number \tSquared  Cubed");
            Console.WriteLine("====== \t=======  =====");
            WriteOutput(myInt);
            Console.ReadLine();
        }

        public static int Square(int num) => num * num;

        public static int Cube(int num) => num * num * num;

        public static void WriteOutput(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i + "\t" + Square(i) + "\t " + Cube(i));
            }
        }
    }
}
