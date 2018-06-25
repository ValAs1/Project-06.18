using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        //tvi amenamec tvanshan@ gtnel
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int max = MaxDigits(num);
            Console.WriteLine(max);
        }

        static int MaxDigits(int item)
        {
            int max = -1;
            while (item > 0)
            {
                int k = item % 10;
                item = item / 10;
                if (k > max)
                {
                    max = k;
                }
            }
            return max;
        }
    }
}
