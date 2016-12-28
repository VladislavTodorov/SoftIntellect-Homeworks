/*Напишете програма, която за дадени две числа, намира най-големия им общ делител.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Biggest_Divdivider
{
    class BiggestDiv
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int thirdNum = 0;
            
            if (firstNum > secondNum)
            {
                thirdNum = secondNum;
            }

            else if (firstNum < secondNum)
            {
                thirdNum = firstNum;
            }

            else  //значи числата са равни
            {
                thirdNum = firstNum;
            }


            int GCD = 0;

            for (int i = 1; i <= Math.Abs(thirdNum); i++)
            {
                if (firstNum % i == 0 && secondNum % i == 0)
                {
                    GCD = i;
                }

            }

            Console.WriteLine(GCD);

        }
    }
}

