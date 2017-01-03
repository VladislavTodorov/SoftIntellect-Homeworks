/*Напишете програма, която обръща стойностите на един масив.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reversing_The_Array
{
    class ReversingTheArray
    {
        static void Main(string[] args)
        {
            //за по-лесно просто ще задам един масив

            double[] array = { 1.0, 2.0, 3.3, 4.044, 5.31 };

            //отпечатваме го за да го видим
            Console.WriteLine("The array is:");

            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();


            //да го реверсираме и отпечатим
            foreach (var item in array.Reverse())
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }
    }
}
