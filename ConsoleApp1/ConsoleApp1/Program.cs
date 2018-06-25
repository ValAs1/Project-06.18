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
            int[] arr = { 1, 12, 15, 15, 5, 1 };
            int max = MaxRev(arr);
        }

        static int Rev(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int k = x % 10;
                rev = rev * 10 + k;
                x = x / 10;
            }
            return rev;
        }

        static int MaxRev(int[] arr)
        {
            int maxRev = Rev(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxRev < Rev(arr[i]))
                {
                    maxRev = arr[i];
                }
            }
            return maxRev;
        }
    }
}
