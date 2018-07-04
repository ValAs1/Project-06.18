using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
        class Program
        {
            /*2. unenq zangvaci zangvac (qrqrvac, jagged) 
            2.1 gtnel yuraqanchyur toxi (zangvaci ) gumar@ 
            2.2 gtnel yuraqancyur toxi max @*/
            static void Main(string[] args)
            {
                int[][] array = CreatJagedArrays();

                int[][] jarr = CreatRandomArray(array);

                Print(jarr);

                int[] jMax = GetMaxRow(jarr);

                for (int i = 0; i < jMax.Length; i++)
                {
                    Console.WriteLine("Jagged Max = " + jMax[i]);
                }

                int[] sum = GetSumJagged(jarr);

                for (int i = 0; i < sum.Length; i++)
                {
                    Console.WriteLine("Sum Jagged = " + sum[i]);
                }
            }

            static int[][] CreatJagedArrays()
            {
                Random rnd = new Random();

                int[][] array = new int[4][];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new int[8];
                }

                return array;
            }

            static int[][] CreatRandomArray(int[][] array)
            {
                Random rnd = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] = rnd.Next(1, 100);
                    }
                }

                return array;
            }

            static void Print(int[][] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write(array[i][j] + "\t ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            static int[] GetMaxRow(int[][] array)
            {
                int[] max = new int[array.GetLength(0)];

                for (int i = 0; i < array.Length; i++)
                {
                    max[i] = array[i][0];
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        if (max[i] < array[i][j])
                        {
                            max[i] = array[i][j];
                        }
                    }
                }

                return max;
            }

            static int[] GetSumJagged(int[]  [] array)
            {
                int[] sum = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    sum[i] = array[i].Sum();
                }

                return sum;
            }

        }
    
}
