/*Напишете програма, която приема стринг от конзолата, и извежда N-тия символ от стринга, като резултат.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.N_Symbol_From_Str
{
    class NSymbolFromStr
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int indexStrSymbol = int.Parse(Console.ReadLine());

            Console.WriteLine(str[indexStrSymbol]);
        }
    }
}
