/* Напишете програма, която чете от конзолата поредица от цели числа (примерно 5 числа) и отпечатва най-малкото и най-голямото от тях.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06а.Smillest_And_Biggest_Num
{
    class SmillestAndBiggestNum
    {
        static void Main()
        {
            //не разбрах, но да допуснем, че са поредица от произвилни числа разделени със запетая например: 43,546,786,-65,77
           
            string[] inputStr = Console.ReadLine().Split(',');

            int smillest = int.MaxValue;
            int biggest = int.MinValue;

            foreach (var item in inputStr)
            {
                int currentNum = int.Parse(item);

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
