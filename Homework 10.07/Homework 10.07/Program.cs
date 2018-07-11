using System;

namespace Homework_10._07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreatRandomArray(500);
            Print(array);
            RatingArray(array);
            Console.ReadLine();
        }

        static int[] CreatRandomArray(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 21);
            }
            return array;
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }
        //static void RatingArray(int[] array)
        //{
        //    int[] arr = new int[21];

        //    for (int j = 0; j < arr.Length; j++)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (array[i] == j)
        //            {
        //                arr[j] += 1;
        //            }
        //        }
        //    }

        //    Print(arr);
        //}
        static void RatingArray(int[] array)
        {
            int[] arr = new int[21];
            foreach (var item in array)
            {
                arr[item]++;
            }
            Print( arr);
        }
    }
}
