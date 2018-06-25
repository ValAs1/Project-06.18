using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. gtnel zuyg tveri mijin tvabanakan@ 
            int[] array = CreateRandomArray(5);
            // int a = 5;
            int[] EArray = EvenNum(array);
            int sum = SumaArray(EArray);
            Console.WriteLine(sum);
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

        static int[] EvenNum(int[] array)
        {
            int[] EArray = new int[array.Length];
            for (int i = 0; i < EArray.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    EArray[i] = array[i];
                }
                else
                {
                    EArray[i] = 0;
                }
               // Console.WriteLine(EArray[i]);
            }
            return EArray;
        }

        static int SumaArray(int[] EArray)
        {
            int sum1 = 0;
            int count = 0;
            for (int i = 0; i<EArray.Length; i++)
			{
             sum1 =sum1+EArray[i];
              count++;
			}
            int sum = sum1 / count;
            return sum;
        }
    }
}
