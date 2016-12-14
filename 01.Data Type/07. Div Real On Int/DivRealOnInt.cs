/*Напишете програма, която приема реално число като вход, и изкарва на конзолата резултата от делението му с цяло число.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Div_Real_On_Int
{
    class DivRealOnInt
    {
        static void Main(string[] args)
        {
            double realNum = double.Parse(Console.ReadLine());
            int intNum = int.Parse(Console.ReadLine());

            Console.WriteLine(realNum / intNum);
        }
    }
}
