using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        class Program
        {
            static void Main(string[] args)
            {
                int[,] arr = CreateRandomArray();
                PrintArray(arr);

                int[] max = GetMaxRows(arr);
                for (int i = 0; i < max.Length; i++)
                {
                    Console.WriteLine($"max value of each row: {max[i]}");

                }

                int[] maxCol = GetMaxColumns(arr);
                for (int i = 0; i < maxCol.Length; i++)
                {
                    Console.WriteLine($"max value of each column: {maxCol[i]}");

                }

                Console.ReadLine();
            }
            static int[] GetMaxColumns(int[,] arr)
            {
                int[] max = new int[arr.GetLength(1)];

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        max[j] = arr[0, j];
                        if (max[j] < arr[i, j])
                        {
                            max[j] = arr[i, j];
                        }
                    }
                }
                return max;
            }


            /// <summary>
            /// Get Max of rows
            /// </summary>
            /// <param name="arr"></param>
            /// <returns></returns>
            static int[] GetMaxRows(int[,] arr)
            {
                int[] max = new int[arr.GetLength(0)];

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    max[i] = arr[i, 0];

                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (max[i] < arr[i, j])
                        {
                            max[i] = arr[i, j];
                        }
                    }
                }
                return max;
            }

            /// <summary>
            /// Random array creation
            /// </summary>
            /// <param name="row"></param>
            /// <param name="col"></param>
            /// <param name="minValue"></param>
            /// <param name="maxValue"></param>
            /// <returns></returns>
            static int[,] CreateRandomArray(int row = 4, int col = 4, int minValue = 10, int maxValue = 100)
            {

                int[,] arr = new int[row, col];
                Random rnd = new Random();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = rnd.Next(minValue, maxValue);
                    }
                }
                return arr;
            }

            /// <summary>
            /// Array print
            /// </summary>
            /// <param name="array"></param>
            static void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(" " + array[i, j]);
                    }
                    Console.WriteLine();
                }
            }

        }

    
}
