using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            SurnameArr();
            Console.Read();

        }
        static void SortListByRates(int[] rateArr, string[] nameArr, string[] surnameArr, int[] ageArr)
        {
            for (int i = 0; i < rateArr.Length - 2; i++)
            {
                for (int j = 0; j < rateArr.Length - i - 2; j++)
                {
                    if (rateArr[j] > rateArr[j + 1])
                    {
                        int tempRate = rateArr[j + 1];
                        rateArr[j + 1] = rateArr[j];
                        rateArr[j] = tempRate;
                        int tempAge = ageArr[j + 1];
                        ageArr[j + 1] = ageArr[j];
                        ageArr[j] = tempAge;
                        string tempName = nameArr[j + 1];
                        nameArr[j + 1] = nameArr[j];
                        nameArr[j] = tempName;
                        string tempsurnameArr = surnameArr[j + 1];
                        surnameArr[j + 1] = surnameArr[j];
                        surnameArr[j] = tempsurnameArr;
                    }
                }
            }
            int sum = 0;
            int[] count = new int[20];
            for (int i = 0; i < rateArr.Length; i++)
            {
                count[rateArr[i] - 1]++;
                Console.Write("Anun: " + nameArr[i] + "  ");
                Console.Write("Azganun: " + surnameArr[i] + "  ");
                Console.Write("Tariq: " + ageArr[i] + "--");
                Console.Write("Gnahatakan: " + rateArr[i]);
                Console.WriteLine();
            }
            for (int i = 0; i < count.Length; i++)
            {

                Console.WriteLine(i + 1 + "-stacel en:" + count[i] + " hogi");

                sum += count[i];
            }
            Console.WriteLine("qnnutyan masnakicneri qanak@:" + sum);
        }
        static void SurnameArr(int count = 10000, int minValue = 1, int maxValue = 21)
        {

            string[] nameArr = new string[count];

            string[] surnameArr = new string[count];
            int[] ageArr = new int[count];
            int[] rateArr = new int[count];
            Random rnd = new Random();
            #region MyRegion
            string[] nameArr1 = { "Armen", "Gexam", "Vardan", "Movses", "Valodya", "Edgar", "Margar", "Xachik", "Sipan", "Simon", "Sargis" };
            string[] surnameArr1 = { "Sargsyan", "Martirosyan", "Hayrapetyan", "Yeghiazaryan", "Vardanyan", "Sahakyan", "Levonyan", "Mamikonyan", "Nersisyan", "Nikoghosyan", "Piloyan" };

            #endregion
            for (int i = 0; i < count; i++)
            {
                nameArr[i] = nameArr1[rnd.Next(0, nameArr1.Length - 1)];
                surnameArr[i] = surnameArr1[rnd.Next(0, surnameArr1.Length - 1)];
                ageArr[i] = rnd.Next(17, 19);
                rateArr[i] = rnd.Next(minValue, maxValue);
            };
            SortListByRates(rateArr, nameArr, surnameArr, ageArr);



        }
    }
}
