/* Напишете програма, която чете от конзолата поредица от цели числа (примерно 5 числа) и отпечатва най-малкото и най-голямото от тях.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06b.Smillest_And_Biggest_Num
{
    class SmillestAndBiggestNum
    {
        static void Main()
        {
            //да допуснем, че предварително задаваме броя на числата

            int cash = int.Parse(Console.ReadLine());

            int biggest = int.MinValue;
            int smillest = int.MaxValue;

            for (int i = 0; i < cash; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < smillest)
                {
                    smillest = currentNum;
                }
                if (currentNum > biggest)
                {
                    biggest = currentNum;
                }
            }

            Console.WriteLine(smillest);
            Console.WriteLine(biggest);

        }
    }
}
