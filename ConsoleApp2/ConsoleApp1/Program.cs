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
            int[,] array = CreatRandomArray(row, col);
            
            PrintMatrix(array, row, col);
            int secMax = GetMaxSecondDiagonal(array, row, col);
            Console.WriteLine(secMax);

            
            Console.ReadLine();
        }

        static int[,] CreatRandomArray(int row, int col)
        {
            Random rnd = new Random();
            int[,] array = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                }
            }
            return array;
        }

        static void PrintMatrix(int[,] array, int row , int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        //3. unenq 2 chap zangvac gtnel 2rdayin ankyunagcic amenamec@
        static int GetMaxSecondDiagonal(int[,] array, int row, int col)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i + j == 5 - 1 && array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
    }
}
