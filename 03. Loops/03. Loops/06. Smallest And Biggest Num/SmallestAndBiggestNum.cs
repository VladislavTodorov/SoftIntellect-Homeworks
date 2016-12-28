/* Напишете програма, която чете от конзолата поредица от цели числа (примерно 5 числа) и отпечатва най-малкото и най-голямото от тях.*/

using System;

namespace _06.Smallest_And_Biggest_Num
{
    class SmallestAndBiggestNum
    {
        static void Main()
        {
            //не разбрах, но да допуснем, че са поредица едноцифрени от 0 до 9 слято напр.: 543677403

            string inputStr = (Console.ReadLine());

            int smillest = int.MaxValue;
            int biggest = int.MinValue;

            for (int i = 0; i < inputStr.Length; i++)
            {
                int currentNum = (inputStr[i] - 48);

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
