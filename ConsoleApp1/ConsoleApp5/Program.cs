using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //   1. zangvaci mej max u min texerov poxel

            int[] array = CreateRandomArray(5);
            int max = GetMax(array);
            int min = GetMin(array);
            int[] RArray = MoveMaxAndMin(array, max, min);
           
            // Console.WriteLine(array);   //???????
            Console.WriteLine("\n Max - " + max);
            Console.WriteLine("\n Min - " + min);
            // Console.WriteLine(RArray);          //?????????????
            Console.ReadLine();
        }
        static int[] CreateRandomArray(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 30);
                Console.WriteLine(array[i]);
            }
            return array;
        }

        static int GetMax(int[] array)
        {
            int max = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        static int GetMin(int[] array)
        {
            int min = array[0];             ///??????????????????????
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        static int[] MoveMaxAndMin(int[] array, int max, int min)
        {
            int[] RArray = new int[array.Length];
            for (int i = 0; i < RArray.Length; i++)
            {
                if (array[i] == max)
                {
                    RArray[i] = min;
                }
                else if (array[i] == min)
                {
                    RArray[i] = max;
                }
                else
                {
                    RArray[i] = array[i];
                }
               Console.WriteLine(RArray[i]);
            }
            return RArray;
        }
    }
}
