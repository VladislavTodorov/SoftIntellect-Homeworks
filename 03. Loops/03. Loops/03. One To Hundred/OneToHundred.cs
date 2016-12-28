/*Направете програма, която извежда на конзолата всички числа от 1 до 100, които се делят или на 7, или на 11, без остатък*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.One_To_Hundred
{
    class OneToHundred
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                if ((i % 7 == 0) || (i % 11 == 0))
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
