using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_28._06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = CreatRandomArray(5, 5);
            Print(array);


            int[] max = GetMaxRows(array);
            for (int i = 0; i < max.Length; i++)
            {
                Console.WriteLine($"max value of each row: {max[i]}");

            }

        }

        static int[,] CreatRandomArray(int count1, int count2)
        {
            Random rnd = new Random();
            int[,] array = new int[count1, count2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                }
            }
            return array;
        }

        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        static int[] GetMaxRows(int[,] array)
        {
            int[] max = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                max[i] = array[i, 0];

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max[i] < array[i, j])
                    {
                        max[i] = array[i, j];
                    }
                }


            }

            return max;
        }
    }
}
