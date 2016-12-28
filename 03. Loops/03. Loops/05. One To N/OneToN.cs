/*Напишете програма, която отпечатва на конзолата числата от 1 до N, които не се делят на 3 и 7. Числото N се въвежда от конзолата.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.One_To_N
{
    class OneToN
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if ((i % 3 == 0) || (i % 7 == 0))
                {
                    continue;
                }

                Console.WriteLine(i);

            }

        }
    }
}
