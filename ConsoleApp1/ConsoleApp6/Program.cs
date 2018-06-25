using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        //gtnel zangvaci zuyg tveri mijin tvabanakan@
        static void Main(string[] args)
        {
            int[] array = { 12, 15, 6, 3, 16, 1 };
            //int midl = TheArithmeticAverage(array);
            //Console.WriteLine(midl);

        }

        static int EvenNum(int[] array)
        {
            int eNum = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    eNum = array[i];
                }
                Console.WriteLine(eNum);
            }
            return eNum;
        }

        //static int TheArithmeticAverage(int[] arr)
        //{
        //    int midl = -1;
        //    int sum = 0;
        //    int count = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        count = count + arr[i];
        //        sum++;
        //        midl = count / sum;
        //    }
        //    return midl;
        //}
    }
}
