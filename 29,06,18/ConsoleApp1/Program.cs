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
            int row = 5;
            int col = 5;
            int[,] matrix = CreateRandomArray(row, col);

            Print(matrix);
           
            Console.ReadKey();
        }
        /// <summary>

        /// Filling some Random numbers

        /// </summary>

        /// <param name="row">AAAA</param>

        /// <param name="col">BBBB</param>

        /// <param name="minValue"></param>

        /// <param name="maxValue"></param>

        /// <returns></returns>

        static int[,] CreateRandomArray(int row = 5, int col = 5, int minValue = 10, int maxValue = 100)
        {
            Random rand = new Random();
            int[,] array = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = rand.Next(minValue, maxValue);
                }
            }
            return array;
        }
        
        /// <summary>
        /// Printing
        /// </summary>
        /// <param name="array"></param>
        static void Print(int[,] array)
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
