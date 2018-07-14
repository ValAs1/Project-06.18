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
            int n = 15;
            int[] ID = CreateID(n);
            string[] names= CreateNames(n);
            string[] surnames = CreateSurnames(n);
            int[] ages = CreateAges(n);
            PrintArray(names, surnames, ages, ID);
            Console.WriteLine("<<<<<<<<<<<<<<< Shuffle >>>>>>>>>>>>>>>>>");
            Shuffle(ID);
            PrintArray(names, surnames, ages, ID);
            int[][] grouped = GroupedId(ID, 3);
            PrintArray(names, surnames, ages, grouped);
            Console.ReadLine();
        }

        ////////static void PrintArray(string[] arr, string[] arr1, int[] arr2, int[][] jarr)
        ////////{

        ////////    for (int i = 0; i < jarr.Length; i++)
        ////////    {
        ////////        Console.WriteLine(i + 1 + "- GROUP!!!!!!!!!!!!!!!!!!!!!!!!!!1");
        ////////        Console.WriteLine();
        ////////        for (int j = 0; j < jarr[i].Length; j++)
        ////////        {
        ////////            Console.Write("Name:" + arr[jarr[i][j]] + "  surname: " + arr1[jarr[i][j]] + "  age:" + arr2[jarr[i][j]]);
        ////////            Console.WriteLine();
        ////////        }

        ////////    }
        ////////}

        ////////static int[][] GroupedId(int[] ID, int num)
        ////////{
        ////////    int[][] array = new int[num][];
        ////////    if (ID.Length % num==0 )
        ////////    {
        ////////        for (int i = 0; i < array.Length; i++)
        ////////        {
        ////////            //array[i] = new int[ID.Length % num];
        ////////            for (int j = 0; j < ID.Length % num; j++)
        ////////            {
        ////////                array[i][j] = ID[i];
        ////////            }
        ////////        }
        ////////    }
        ////////    else if(ID.Length%num>0.5)
        ////////    {
        ////////        for (int i = 0; i < array.Length; i++)
        ////////        {
        ////////            array[i] = new int[ID.Length % num + 1];
        ////////            for (int j = 0; j < array[i].Length; j++)
        ////////            {
        ////////                array[i][j] = ID[i];
        ////////            }
        ////////        }
        ////////    }
        ////////    else
        ////////    {
        ////////        for (int i = 0; i < array.Length; i++)
        ////////        {
        ////////            array[i] = new int[ID.Length % num + 1];
        ////////            for (int j = 0; j < array[i].Length; j++)
        ////////            {
        ////////                array[i][j] = ID[i];
        ////////            }
        ////////        }
        ////////    }
        ////////    return array;
        ////////}
        static void Shuffle(int[] ID)
        {
            int item = ID.Length;
            Random rnd = new Random();
            while (item > 0)
            {
                int x = rnd.Next(item--);
                Swap(ID , item, x );
            }
        }

        static void Swap(int[] ID, int index1, int index2)
        {
            int item = ID[index1];
            ID[index1] = ID[index2];
            ID[index2] = item;
        }

        static void PrintArray(string[] names, string[] surnames, int[] ages, int[] ID)
        {
            for (int i = 0; i < ID.Length; i++)
            {
                Console.Write(i + 1 + "\t|" + ID[i] +"\t|"+ names[ID[i]] + "\t|" + surnames[ID[i]] + "\t|" + ages[ID[i]] + "\t|");
                Console.WriteLine();
            }
        }

        static int[] CreateID(int  count)
        {
            int[] ID = new int[count];
            for (int i = 0; i < ID.Length; i++)
            {
                ID[i] = i;
            }
            return ID;
        }

        static string[] CreateNames(int count)
        {
            string[] names = new string[count];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = "A" + i;
            }
            return names;
        }
        
        static string[] CreateSurnames(int count)
        {
            string[] surnames = new string[count];
            for (int i = 0; i < surnames.Length; i++)
            {
                surnames[i] = "A" + i + "yan";
            }
            return surnames;
        }

        static int[] CreateAges(int count)
        {
            Random rnd = new Random();
            int[] ages = new int[count];
            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = rnd.Next(0, 20);
            }
            return ages;
        }
    }
}
