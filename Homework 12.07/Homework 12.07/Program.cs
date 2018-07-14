using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12._07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = CreateNames(11);
            string[] surnames = CreateSurNames(11);
            int[] ages = CreateAges(11);
            int[] ids = CreateIds(11);
            int[] shIds = Shuffle(ids);
            int[][] emptyGroup = EmptyGroup(shIds, 3);
            int[][] groupedId = GroupedId(shIds, emptyGroup);
            PrintArray(names, surnames, ages, ids);

            Console.WriteLine("################################################");

            PrintArray(names, surnames, ages, shIds);
            Console.WriteLine("Grouped");
            PrintArray(names, surnames, ages, groupedId);
            Console.WriteLine("################################################");
            Console.Read();
        }
        static int[][] GroupedId(int[] shList, int[][] groupList)
        {

            int temp = 0;
            for (int i = 0; i < groupList.Length; i++)
            {
                for (int j = 0; j < groupList[i].Length; j++)
                {

                    groupList[i][j] = shList[temp];
                    temp++;
                }
            }
            return groupList;
        }
        static int[][] EmptyGroup(int[] shIds, int num)
        {
            int[][] groupeList = new int[num][];
            for (int i = 0; i < num; i++)
            {
                int length = shIds.Length;
                if (length % num == 0 && length >= num)
                {
                    groupeList[i] = new int[length / num];
                }
                else if (length % num != 0 && length >= num)
                {
                    int c = length - num * (length / num);

                    int b = (length - c) / num;
                    groupeList[i] = new int[b];
                    if (i >= num - c)
                    {
                        groupeList[i] = new int[b + 1];
                    }
                }

            }
            return groupeList;
        }
        static int[] Shuffle(int[] id)
        {
            List<int> list = new List<int>(id.Length);
            List<int> list1 = new List<int>(id.Length);
            int[] idNew = new int[id.Length];
            list.AddRange(id);
            Random rnd = new Random();

            for (int i = 0; i < id.Length; i++)
            {
                int item = rnd.Next(0, list.Count - 1);
                list1.Add(list[item]);
                list.RemoveAt(item);
            }
            idNew = list1.ToArray();
            return idNew;
        }
        static int[] CreateIds(int count)
        {
            int[] ids = new int[count];
            for (int i = 0; i < ids.Length; i++)
            {
                ids[i] = i;
            }
            return ids;
        }

        static void PrintArray(string[] arr, string[] arr1, int[] arr2, int[][] jarr)
        {

            for (int i = 0; i < jarr.Length; i++)
            {
                Console.WriteLine(i + 1 + "- GROUP!!!!!!!!!!!!!!!!!!!!!!!!!!1");
                Console.WriteLine();
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write("Name:" + arr[jarr[i][j]] + "  surname: " + arr1[jarr[i][j]] + "  age:" + arr2[jarr[i][j]]);
                    Console.WriteLine();
                }

            }
        }

        static void PrintArray(int[] arr, int[] id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.Write($"{arr[id[i]]}    ");
            }
        }
        static void PrintArray(string[] arr, string[] arr1, int[] arr2, int[] id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.Write(arr[id[i]] + " " + arr1[id[i]] + " " + arr2[id[i]] + " ");
                Console.WriteLine();

            }
        }
        static int[] CreateAges(int count = 10, int minValue = 20, int maxValue = 100)
        {
            Random rnd = new Random();
            int[] ages = new int[count];

            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = rnd.Next(minValue, maxValue);
            }
            return ages;
        }
        static string[] CreateSurNames(int count)
        {
            string[] surnames = new string[count];
            for (int i = 0; i < surnames.Length; i++)
            {
                surnames[i] = "A" + i + "yan";
            }
            return surnames;
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
    }
}
