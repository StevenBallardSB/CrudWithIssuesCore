using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrolStructurePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberPyramid();
            Console.WriteLine();
            StarAustrailianPyramid();
            Console.WriteLine();
            Console.WriteLine();
            Ravine();
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void Ravine()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("\\");
                for(int slash = 2; slash <= i; slash++)
                {
                    Console.Write(" \\");
                }
                for(int j = 1; j <= 10 - i * 2; j++)
                {
                    Console.Write("*");
                }
                for(int back = 1; back <= i; back++)
                {
                    Console.Write("/");
                }
                Console.WriteLine();
            }     
        }

        private static void StarAustrailianPyramid()
        {
            for (int i = 6; i >= 1; i--)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
            }
        }

        private static void NumberPyramid()
        {
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);

                }
            }
        }
    }
}
