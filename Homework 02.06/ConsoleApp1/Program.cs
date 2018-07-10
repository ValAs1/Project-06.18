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
            List<int> isPrime = CreatRandomArray(10);

            Print(isPrime);

            Console.WriteLine();

            GetPrime(isPrime);


        }

        static List<int> CreatRandomArray(int count)
        {
            Random rnd = new Random();
            List<int> arr1 = new List<int>();
            int[] array = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 50);
                arr1.Add(array[i]);
            }
            return arr1;
        }

        static void Print(List<int> isPrime)
        {
            foreach (var item in isPrime)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        static bool IsPrime(int item)
        {
            if (item == 2)
            {
                return true;
            }
            if (item < 2 || item % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i < Math.Sqrt(item); i += 2)
            {
                if (item % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void GetPrime(List<int> isPrime)
        {

            foreach (var item in isPrime)
            {
                if (IsPrime(item))
                {

                    Console.WriteLine("\t" + item);
                }
            }

        }
    }
}

