using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__30._07
{
    class Rectangle
    {


        public Rectangle(char sym, int size)
        {
            Sym = sym;
            Size = size;
        }

        public int Size { get; set; }
        public char Sym { get; set; }

        public void Draw()
        {
            int[,] array = new int[Size, Size];
            for (int i = 0; i < Size / 2; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(Sym);
                }
                Console.WriteLine();
            }
        }


    }
}
