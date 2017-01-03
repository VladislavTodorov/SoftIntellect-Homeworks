/*Напишете програма, която създава масив с 10 елемента от целочислен тип и инициализира елементите със стойност индекса  умножен по 10.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Index_Value_Multiplied_By_Ten
{
    class IndexValueMultipliedByTen
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i * 10);
            }

            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
