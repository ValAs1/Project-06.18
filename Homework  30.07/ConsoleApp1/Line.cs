using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Line:Parameters
    {
        public void Draw()
        {
           
            for (int i = 0; i < a; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
