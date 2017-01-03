/*Напишете програма, която попълва числата на Фибоначи в масив. Потребител въвежда колко да е голям масива.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Of_Fibunacci_Numbers
{
    class ArrayOfFibunacciNumbers
    {
        static void Main(string[] args)
        {
            // потребителя определя дължината na масива            

            Console.WriteLine("Enter a lenght of array");

            int lenghtArr = int.Parse(Console.ReadLine());


            //за фибоначи трябват поне 2 числа
            if (lenghtArr < 2)
            {
                Console.WriteLine("Няма числа на Фибоначи");
            }
            else
            {
                int[] Array = new int[lenghtArr];

                Array[0] = 0;
                Array[1] = 1;

                for (int i = 2; i < Array.Length; i++)
                {
                    Array[i] = (Array[(i - 1)] + Array[(i - 2)]);
                }

                Console.WriteLine("The Fibonacci array is: ");

                foreach (var item in Array)
                {
                    Console.Write("{0} ", item);
                }

                Console.WriteLine();
            }
        }
    }
}
