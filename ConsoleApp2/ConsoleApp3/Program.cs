using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = CreateRandomArray(4, 4, 0, 20);
            PrintArray(array);
            Console.WriteLine("The maximum of the array is " + GetMax(array));
            Console.WriteLine("The maximum in the main diagonal is " + GetMaxinMainDiagonal(array, 4, 4));
            Console.WriteLine("The maximum in the secondary diagonal is " + GetMaxinSecondaryDiagonal(array, 4, 4));
            Console.WriteLine("The maximum under the main diagonal is  " + GetMaxUnderMainDiagonal(array, 4, 4));
        }

        static int[,] CreateRandomArray(int length, int width, int minValue, int maxValue)
        {
            int[,] arr;
            arr = new int[length, width];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i, j] = rand.Next(minValue, maxValue);
                }
            }
            return arr;
        }

        static void PrintArray(int[,] arr)
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static int GetMax(int[,] arr)
        {
            int max = arr[0, 0];
            foreach (int item in arr)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        static int GetMaxinMainDiagonal(int[,] arr, int length, int width)
        {
            int max = arr[0, 0];
            for (int i = 0; i < length; i++)
            {
                if (arr[i, i] > max)
                    max = arr[i, i];
            }
            return max;
        }

        static int GetMaxinSecondaryDiagonal(int[,] arr, int length, int width)
        {
            int max = arr[0, length - 1];
            for (int i = 0; i < length; i++)
            {
                for (int j = length - 1; j >= 0; j--)
                {
                    if (arr[i, j] > max)
                        max = arr[i, j];
                }
            }
            return max;
        }

        static int GetMaxUnderMainDiagonal(int[,] arr, int length, int width)
        {
            int max = arr[1, 0];
            for (int i = 1; i < length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i, j] > max)
                        max = arr[i, j];
                }
            }
            return max;
        }


    }
}
