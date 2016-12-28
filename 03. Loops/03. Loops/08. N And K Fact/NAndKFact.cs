/*Напишете програма, която пресмята N!*K!/(N-K)! за дадени N и K. **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.N_And_K_Fact
{
    class NAndKFact
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int nLessK = (N - K);

            int nFact = 1;
            int kFact = 1;
            int nkFact = 1;

            for (int i = 1; i <= N; i++)
            {
                nFact = (nFact * i);

                if (K >= i)
                {
                    kFact = (kFact * i);
                }

                if (nLessK >= i)
                {
                    nkFact = (nkFact * i);
                }
            }

            Console.WriteLine(nFact * kFact / nkFact);           
            
        }
    }
}
