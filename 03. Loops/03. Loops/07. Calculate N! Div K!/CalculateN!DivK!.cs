/* Напишете програма, която пресмята N!/K! за дадени N и K(1<K<N). **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Calculate_N__Div_K_
{
    class CalculateNDivK
    {
        static void Main(string[] args)
        {
            //n!=n*(n-1)*(n-2)*(n-3)

            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            int nFact = 1;
            int kFact = 1;

            for (int i = 1; i <= N; i++)
            {
                nFact = (nFact * i);

                if (K >= i)
                {
                    kFact = (kFact * i);
                }

            }
            
            Console.WriteLine(nFact / kFact);

        }
    }
}
