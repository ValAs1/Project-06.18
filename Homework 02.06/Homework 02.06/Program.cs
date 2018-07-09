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
            Print(surname);
            Print(name);
            Console.WriteLine();
            ShuffleSurnameNameList(name, surname);
            Console.ReadLine();
        }

        static void Print(List<string> surname)
        {
            foreach (string item in surname)
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine();
        }

        static void ShuffleSurnameNameList(List<string> name, List<string> surname)
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
                int x1 = rnd.Next(item1--);
                string n1 = surname[x1];
                surname[x1] = surname[item1];
                surname[item1] = n1;
            }
            int item3 = surname.Count;
            while (item < item3)
            {
                item++;
                surname.Insert(item + item1, name[item1]);
                item1++;
            }
            Console.WriteLine("ShuffleSurnameNameList\n");
            Print(surname);
        }
    }
}
