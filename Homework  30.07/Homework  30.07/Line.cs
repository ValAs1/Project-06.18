using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__30._07
{
    class Line
    {
        public Line(char sym, int size)
        {
            Sym = sym;
            Size = size;
        }
        public char Sym { get; set; }
        public int Size { get; set; }

        public void Draw()
        {
            int[] array = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Console.Write(Sym);
            }
            Console.WriteLine();
        }
    }
}
