using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = CratRandomArray(5, 5);
            PrinteMatrix(array);

            int SecMax = GetMaxSecondDiaganal(array);
            Console.WriteLine(SecMax);
            Console.ReadLine();
        }
        static int[,] CratRandomArray(int count1, int count2)
        {
            Random rnd = new Random();
            int[,] array = new int[count1, count2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 50);
                }
            }
            return array;
        }
        static void PrinteMatrix(int[,] array)
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
        static int GetMaxSecondDiaganal(int[,] array)
        {
            int SecMax = array[0, array.GetLength(1)-1];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = array.GetLength(1)-1-i; j == array.GetLength(1)-1-i; j--)
                {
                    if (array[i,j]>SecMax)
                    {
                        SecMax=array[i,j];
                    }
                }
            }
            return SecMax;
        }

    }
}

