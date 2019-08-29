using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program takes in an array of numbers that you input then doubles them.");
            //creates the user generated array
            int[] array = CreateArray();
            //doubles the user generated array
            int[] arraydoubled = CopyAndDoubleArray(array);
            //displays the array
            DisplayArrays(array, arraydoubled);

        }

        
        private static void DisplayArrays(int[] array, int[] arraydoubled)
        {
            Console.Write("User's Array: ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[array.Length - 1]);
            Console.Write("Users's Array doubled: ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{arraydoubled[i]}, ");
            }
            Console.WriteLine(arraydoubled[arraydoubled.Length - 1]);
            Console.ReadLine();
        }

        private static int[] CopyAndDoubleArray(int[] array)
        {
            int[] array2 = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i] * 2;
            }
            return array2;
        }

        private static int[] CreateArray()
        {
            Console.WriteLine("Enter numbers until you have either entered 10 numbers or if you want to cut off early, enter a zero.");
            Console.WriteLine("After the number is typed, press enter to submit it into the array.");
            int[] Array = new int[10];
            for(int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Enter a number.");
                Array[i] = Convert.ToInt32(Console.ReadLine());
                if (Array[i] == 0)
                {
                    i = Array.Length;
                }
            }
            return Array;
        }
    }
}
