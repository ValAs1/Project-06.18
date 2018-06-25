using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum123 = SumOfDigits(123);
            //int sumN123 = SumOfDigits(-123);
            //int sum0 = SumOfDigits(0);
            int[] arr = { };
            int max = MaxSumOfDigits(arr);
            if (max == -1)
            {
                Console.WriteLine("0000");
            }
            else
            {
                Console.WriteLine(max);
            }
        }
        static int SumOfDigits(int num)
        {
            num = Math.Abs(num);

            int sum = 0;
            while (num > 0)
            {
                int remaider = num % 10;
                sum = sum + remaider;
                num /= 10;
            }
            return sum;
        }
        static int MaxSumOfDigits(int[] arr)
        {
            int max = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int item = SumOfDigits(arr[i]);
                if (max < item)
                {
                    max = item;
                }
            }
            return max;
        }

        static int MinSumOfDigits(int[] arr)
        {
            int min = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int item = SumOfDigits(arr[i]);
                if (min > item)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
