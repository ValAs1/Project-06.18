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
            Console.WriteLine("Triangle");
            var triangle = new Triangle
            {
                symbol = '$',
                a = 5
            };
            triangle.Draw();

            Console.WriteLine();
            Console.WriteLine("Rectrangl \n");
            var rectangle = new Rectangle
            {
                b=10
            };

            rectangle.Draw();
        }

    }
}
