using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum123 = SumOfDigits(123);
            //int sumN123 = SumOfDigits(-123);
            //int sum0 = SumOfDigits(0);

            int[] arr = { 109, 456, 897, 678, 545, 414, 352 };
            //int[] arr = { };

            int max = MaxSumOfDigits(arr);
            if (max == -1)
            {
                Console.WriteLine("barev");
            }
            else
            {
                Console.WriteLine("num with max sum of elements is " + max);
            }
        }
        static int SumOfDigits(int num)
        {
            num = Math.Abs(num);

            int sum = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                sum = sum + remainder;
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

        static int MaxSum(int[] arr)//109, 456, 235, 678, 545, 414, 352
        {
            int num = 0;
            int maxnum = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= 0)
                {
                    continue;
                }
                int sum = 0;
                int x = arr[i];
                while (arr[i] > 0)
                {
                    int remainder = arr[i] % 10;
                    sum = sum + remainder;
                    arr[i] /= 10;
                }
                if (maxnum < sum)
                {
                    maxnum = sum;
                    num = x;
                }
            }
            return num;
        }

    }
}
