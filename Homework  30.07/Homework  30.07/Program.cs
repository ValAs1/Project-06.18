using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__30._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tringle");
            var tringle = new Tringle
            {
                sym = '$',
                size = 5
            };
            tringle.Draw();


            Console.WriteLine();
            Console.WriteLine("Rectrangl \n");
            var rectangle = new Rectangle('*', 10);

            rectangle.Draw();

            Console.WriteLine();
            Console.WriteLine("Line \n");

            var line = new Line('&', 15);
            line.Draw();

            Console.WriteLine("\n Square \n");
            var square = new Square('%', 9);
            square.Draw();

        }
    }
}
