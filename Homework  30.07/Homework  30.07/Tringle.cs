using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__30._07
{
    #region Tringle
    class Tringle
    {
        public char sym;
        public int size;

        public void Draw()
        {
            int[,] array = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(sym);
                }
                Console.WriteLine();
            }
        }
    }
    #endregion
}
