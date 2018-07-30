using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_26._07
{
    class Kube
    {

        // public int cou = 0;
        //  public Kube 

        private int cou;
        public int Cou
        {
            get { return cou; }
            //set
            //{
            //    if (value < 17 || value > 50)
            //        cou = 0;
            //    else
            //        cou = value;
            //}
        }



        public  void Setkube(int value)
        {
            int[,] arr = new int[value, value];


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}
