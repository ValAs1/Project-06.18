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
           
            int[,] array = CreatRandomArray(5, 5);
            PrintMatrix(array);

            //int max = MaxMatrix(array);
            //Console.WriteLine(max);

            //int genMax = GetMaxGeneralDiagonal(array);
            //Console.WriteLine(genMax);

            int secMax = GetMaxSecondDiagonal(array);
            Console.WriteLine("The maximum in the secondary diagonal is - " + secMax);


            //int lowMax = GetMaxLowerDiagonal(array);
            //Console.WriteLine(lowMax);
            Console.ReadLine();
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

        static void PrintMatrix(int[,] array)
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

        //1. unenq 2chap zangvac, gtnel max
        static int MaxMatrix(int[,] array)
        {
            int max = array[0, 0];
            foreach (var item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        //2. unenq 2 chap zangvac gtnel glxavor ankyunagcic max@
        static int GetMaxGeneralDiagonal(int[,] array)
        {
            int max = -1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j && array[i, i] > max)
                    {
                        max = array[i, i];
                    }
                }
            }
            return max;
        }

        //3. unenq 2 chap zangvac gtnel 2rdayin ankyunagcic amenamec@
        static int GetMaxSecondDiagonal(int[,] array)
        {
            int max = array[0, array.GetLength(1)-1 ];
            for (int i =0; i< array.GetLength(0); i++)
            {
                for (int j = array.GetLength(1)-1-i; j == array.GetLength(1) - i-1; j--)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        // 4. unenq 2chap zangvac gtnel glxavor ankyunagci u dranic nerqev gtnvox elementneric max
        static int GetMaxLowerDiagonal(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i >= j && array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;

        }
    }
}
