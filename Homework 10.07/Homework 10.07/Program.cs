using System;

namespace Homework_10._07
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int[] arr = CreatRandomArray(4);
            PrintArray(arr);
            
            Console.ReadLine();
        }
        static int[] CreatRandomArray(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 2);
            }
            return array;
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }

    }
}
