using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //3 unenq zangvac gtnel parz tver@ (list - i mej )

        static void Main(string[] args)
        {
            int[] NewArray = CreateRandomArray(7);
            PrintArray(NewArray);
            SelectionSort(7);
            Console.ReadLine();
        }

        static int[] CreateRandomArray(int count)
        {
            int[] arr = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            return arr;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] SelectionSort(int count)
        {
            int[] arr = CreateRandomArray(count);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minval = i;  // min value-n stugvox indexn e
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minval])
                    {
                        minval = j;
                    }
                }
                if (minval != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minval];
                    arr[minval] = temp;
                }
            }
            PrintArray(arr);
            return arr;
        }
    }
}
