using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12._07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[] { "Samvel   ", " Haykuhi", "Anahit", "Hripsime", "Karine  ", "Mery   " };
            string[] surname = new string[] { "Simonyan", "Atoyan", "Khachatryan", "Babayan", "Karapetyan", "Vardanyan" };
            string[] fName = new string[] { "Serob   ", "Gagik   ", "Vladilen", "Samvel  ", "Karlen  ", "Chgitem  " };
            ShafleName(name, surname, fName);
            PrintArray(name);
            PrintArray(surname);
            PrintArray(fName);
            Console.Read();

        }
        static void PrintArray(string[] arr)
        {
            foreach (string item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void ShufleStingArray(string[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {

                int tempIndex = rnd.Next(0, arr.Length - 1);
                string tempStr = arr[i];
                arr[i] = arr[tempIndex];
                arr[tempIndex] = tempStr;
            }
        }
        static void ShafleName(string[] name, string[] surname, string[] fName)
        {
            ShufleStingArray(name);
            ShufleStingArray(surname);
            ShufleStingArray(fName);
        }
        static string[][] ToJaray(string[] name, string[] surname, string[] fName)
        {
            string[][] jarr = new string[name.Length][];
            for (int i = 0; i < jarr.Length; i++)
            {
                for (int j = 0; j < name.Length; j++)
                {
                    jarr[i][j] = name[i];
                }
            }
            return jarr;
        }
    }
}
