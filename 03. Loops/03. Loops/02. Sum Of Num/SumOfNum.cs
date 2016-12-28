/*Напишете програма, която кара потребителя да въвежда числа и ги сумира. Края на програмата настъпва, единствено когато потребителя въведе числото 0.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sum_Of_Num
{
    class SumOfNum
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;

            while (num != 0)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
