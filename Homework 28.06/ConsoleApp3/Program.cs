using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> name = new List<string>(new string[]
            { " srti 7, ", " xachi 7, "," xari 7, ", " qyapi 7, ",
              " srti 8, ", " xachi 8 ,"," xari 8 ,", " qyapi 8, ",
             " srti 9, ", " xachi 9, "," xari 9, ", " qyapi 9, ",
             " srti 10, ", " xachi 10, "," xari 10, ", " qyapi 10, ",
     " srti Valet, ", " xachi Valet, "," xari Valet, ", " qyapi Valet, ",
     " srti Dama, ", " xachi Dama, "," xari Dama, ", " qyapi Dama, ",
     " srti Karol, ", " xachi Karol, "," xari Karol, ", " qyapi Karol, ",
             " srti Tuz, ", " xachi Tuz, "," xari Tuz, ", " qyapi Tuz, ",
             });

            PrintList(name);
            Console.WriteLine();
            ShuffleElementList(name);
            GiveOutCards(name);
            //PrintList(name);

            Console.ReadLine();
        }
        static void PrintList(List<string> name)
        {
            foreach (string item in name)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static void GiveOutCards(List<string> name)
        {
            List<string> Gev = new List<string>();
            List<string> Aram = new List<string>();
            List<string> Ashot = new List<string>();
            List<string> Karen = new List<string>();
            for (int i = 0; i < name.Count; i++)
            {
                if (i < 8)
                {
                    Gev.Add(name[i]);
                }
                else if (i > 8 && i < 16)
                {
                    Aram.Add(name[i]);
                }
                else if (i > 16 && i < 24)
                {
                    Ashot.Add(name[i]);
                }
                else if (i > 24 && i < 33)
                {
                    Karen.Add(name[i]);
                }
            }
            Console.WriteLine(" Gevi  qarer");
            PrintList(Gev);
            Console.WriteLine(" Arami qarer ");
            PrintList(Aram);
            Console.WriteLine(" Ashoti qarer ");
            PrintList(Ashot);
            Console.WriteLine(" Kareni qarer");
            PrintList(Karen);
        }
        static void ShuffleElementList(List<string> name)
        {
            Random rnd = new Random();
            int n = name.Count;
            while (n > 0)
            {
                int rnd_idx = rnd.Next(n--);
                string temp = name[n];
                name[n] = name[rnd_idx];
                name[rnd_idx] = temp;
            }
        }

    }
}

