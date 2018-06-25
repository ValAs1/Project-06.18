using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //3. unenq 2 chap zangvac gtnel 2rdayin ankyunagcic amenamec@
        static void Main(string[] args)
        {
            int[,] array = CreatRandomArray();


            PrintMatrix(array);
            Console.WriteLine();

            //int max = MaxMatrix(array);
            //Console.WriteLine(max);

            //int genMax = GetMaxGeneralDiagonal(array);
            //Console.WriteLine(genMax);

            int secMax = GetMaxSecondDiagonal(array);
            Console.WriteLine(secMax);

            //int lowMax = GetMaxLowerDiagonal(array);
            //Console.WriteLine(lowMax);
            Console.ReadLine();

        }

        static int[,] CreatRandomArray(int row = 5, int col = 5)
        {
            Random rnd = new Random();
            int[,] array = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = rnd.Next(1, 50);
                }
            }
            return array;
        }

        static void PrintMatrix(int[,] array, int row = 5, int col = 5)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        //static int MaxMatrix(int[,] array)
        //{
        //    //1. unenq 2chap zangvac, gtnel max
        //    int max = array[0, 0];
        //    foreach (var item in array)
        //    {
        //        if (item > max)
        //        {
        //            max = item;
        //        }
        //    }
        //    return max;
        //}

        //static int GetMaxGeneralDiagonal(int[,] array)
        //{
        //    //2. unenq 2 chap zangvac gtnel glxavor ankyunagcic max@
        //    int max = -1;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 5; j++)
        //        {
        //            if (i == j && array[i, i] > max)
        //            {
        //                max = array[i, i];
        //            }
        //        }
        //    }
        //    return max;
        //}

        static int GetMaxSecondDiagonal(int[,] array)
        {
            //3. unenq 2 chap zangvac gtnel 2rdayin ankyunagcic amenamec@
            int max = array[0, 0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i + j == 5 - 1 && array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        //static int GetMaxLowerDiagonal(int[,] array)
        //{
        //    // 4. unenq 2chap zangvac gtnel glxavor ankyunagci u dranic nerqev gtnvox elementneric max
        //    int max = array[0, 0];
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 5; j++)
        //        {
        //            if (i >= j && array[i, j] > max)
        //            {
        //                max = array[i, j];
        //            }
        //        }
        //    }
        //    return max;

        //}
    }
}

