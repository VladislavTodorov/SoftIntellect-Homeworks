/*Напишете програма, която приема 2 символни низа (string) като вход, и изведете като резултат конкатениран string със „|“ между двата входни низа.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.String_Concatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();

            Console.WriteLine(firstStr + "|" + secondStr);
        }
    }
}
