using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02._06
{
    class Program
    {

        //1 unenq zangvac, xarnel texer@  (stringeri)
        //5 xarnac@ bajanenq xmberi(or 3)  havasar masi
        //3 unenq zangvac gtnel parz tver@ (list - i mej )
        //4 kardal sortavorman algoritmneri tesakner 2

        static void Main(string[] args)
        {
            List<string> name = new List<string>(new string[] { "Suren", "Ashot", "Narek", "Armen" });
            List<string> surname = new List<string>(new string[] { "Abrahamyan", "Karapetyan", "Simonyan", "Dayan" });
            Print(name);
          Print(surname);
            Console.WriteLine();
            ShuffleElementList(name, surname);
            Console.ReadLine();


        }

        static void Print(List<string> name /*, List<string> surname*/)
        {
            //foreach (string item in name)
            //{
            //    Console.WriteLine("\t" + item );
            //}
            Console.WriteLine();
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("\t" + i);
            }
            Console.WriteLine();
            //foreach (string item1 in surname)
            //{
            //    Console.WriteLine("\t" + item1);
            //}
            //Console.WriteLine();

        }
        static void Printe( List<string> surname)
        {
            //foreach (string item in name)
            //{
            //    Console.WriteLine("\t" + item);
            //}
            //Console.WriteLine();

            foreach (string item1 in surname)
            {
                Console.WriteLine("\t" + item1);
            }
            Console.WriteLine();

        }

        static void ShuffleElementList(List<string> name, List<string> surname)
        {
            Random rnd = new Random();
            int item = name.Count;
            int item1 = name.Count;
            while (item > 0)
            {
                int x = rnd.Next(item--);
                string n = name[x];
                name[x] = name[item];
                name[item] = n;
            }

            while (item1 > 0)
            {
                int x = rnd.Next(item1--);
                string n = surname[x];
                surname[x] = surname[item1];
                surname[item1] = n;
            }
           
            //Console.WriteLine("ShuffleElementList\n");
           Print(name);
         Print(surname);
        }


    }
}
