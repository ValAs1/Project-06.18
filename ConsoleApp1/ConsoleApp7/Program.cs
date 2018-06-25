using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NewArray = new int[5] { 15, 5, 8, 65, 95 };

            // I տարբերակ

            int numMax = MaxValue(NewArray);
            int numMin = MinValue(NewArray);
            Console.WriteLine(numMax);
            Console.WriteLine(numMin);

            //II ըարբերակ
            //int IndexMax = Array.IndexOf(NewArray, NewArray.Max());
            //int indexMin = Array.IndexOf(NewArray, NewArray.Min());

            //int temp = NewArray[IndexMax];
            //NewArray[IndexMax] = NewArray[indexMin];
            //NewArray[indexMin] = temp;

            Console.ReadLine();
        }
        static int MaxValue(int[] arr)
        {
            int max = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int MinValue(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
