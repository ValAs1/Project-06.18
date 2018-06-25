using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. gtnel parz tveri mijin tvabanakan@
            int[] array = CreateRandomArray(5);


        }

        static int[] CreateRandomArray(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 30);
                Console.WriteLine(array[i]);
            }
            return array;
        }

    }
}
