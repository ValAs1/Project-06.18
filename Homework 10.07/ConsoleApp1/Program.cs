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
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //// Array.Reverse(array);
            //for (int i = 0, j= array.Length-1; i<j; i++, j--)
            //{
            //    int a = array[i];
            //    array[i] = array[j];
            //    array[j] = a;
            //}
            //foreach (int i in array)
            //{
            //    Console.Write(i);
            //}
             
            ////  revers    tveri  texer@
            int x= 1564;
                int rev = 0;
                while (x != 0)
                {
                    int k = x % 10;
                    rev = rev * 10 + k;
                    x = x / 10;
                }
            Console.WriteLine(rev); 
                        Console.ReadLine();
        }
    }
}
