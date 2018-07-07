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
            List<string> name = new List<string>(new string[] { "Aram", "Ashot", "Narek", "Armen" });
            Print(name);
            Console.WriteLine();
            ShuffleElementList(name);
        }

        static void Print(List<string> name)
        {
            foreach (string item in name)
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine();
        }

        static void ShuffleElementList(List<string> name)
        {
            Random rnd = new Random();
            int item = name.Count;

            while (item > 0)
            {
                int x = rnd.Next(item--);
                string n = name[x];
                name[x] = name[item];
                name[item] = n;
            }
            Console.WriteLine("ShuffleElementList\n");
            Print(name);
        }
    }
}

