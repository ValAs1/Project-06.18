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
            int n = int.Parse(Console.ReadLine());
            string[] names = Names(n);
            string[] surenames = Surenames(n);
            int[] index = CreatId(n);
            PrintFull(index, names, surenames);
            Shuffle(index);
            PrintFull(index, names, surenames);


        }

        static string[] Names(int item)
        {
            string[] names = new string[item];
            for (int i = 1; i < names.Length; i++)
            {
                names[i] = $"A" + i;
            }
            return names;
        }

        static void PrintFull(int[] index, string[] names, string[] surenames)
        {
            for (int i = 1; i < index.Length; i++)
            {
                Console.WriteLine(index[i] + " _ " + names[i] + " _ " + surenames[i]);
            }
            Console.WriteLine();
        }

        static int[] CreatId(int item)
        {
            int[] index = new int[item];
            for (int i = 1; i < index.Length; i++)
            {
                index[i] = i;
            }
            return index;
        }

        static string[] Surenames(int item)
        {
            string[] surenames = new string[item];
            for (int i = 1; i < surenames.Length; i++)
            {
                surenames[i] = $"A" + i + "yan";
            }
            return surenames;
        }

        static void Print(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        static void Print(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }



        static void Swap(string[] array, int index1, int index2)
        {
            string item = array[index1];
            array[index1] = array[index2];
            array[index2] = item;
        }

        static void Swap(int[] array, int index1, int index2)
        {
            int item = array[index1];
            array[index1] = array[index2];
            array[index2] = item;
        }

        static void Shuffle(int[] index)
        {
            int item = index.Length;
            Random rnd = new Random();
            while (item > 0)
            {
                int x = rnd.Next(item--);
                Swap(index, item, x);
            }
        }
    }
}
