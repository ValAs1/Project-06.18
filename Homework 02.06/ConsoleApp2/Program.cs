using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = CreatRandomArray(5);
            PrintArray(arr);
            ShuffleElementArray(arr);
            Console.ReadLine();
        }
        static int[] CreatRandomArray(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 50);
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
        static void ShuffleElementArray(int[] array)
        {
            Random rnd = new Random();
            int n = array.Length;
            while (n > 0)
            {
                int a = rnd.Next(n--);
                int temp = array[n];
                array[n] = array[a];
                array[a] = temp;
            }
            //int n = 0;
            //while (n <= array.Length)
            //{
            //    int a = rnd.Next(n++);
            //    int temp = array[n];
            //    array[n] = array[a];
            //    array[a] = temp;
            //}
            PrintArray(array);
        }
    }
}
