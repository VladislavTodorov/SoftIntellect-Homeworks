/*Напишете програма, която намира най-често срещания елемент в масив. Нека максималната стойност на елементите в масива да е 100.
 Пример: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (среща се 5 пъти).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.The_Most_Common_Element
{
    class TheMostCommonElement
    {
        static void Main()
        {
            Console.WriteLine("Въведи брой елементи на масива (<= 100):");

            //int[] arr = new int[] { 2, 2, 7, 7, 9, 7, 1 };

            #region Filling an array
            int[] arr = new int[int.Parse(Console.ReadLine())];

            Random rand = new Random();

            //в примера са дадени числа от 0 до 9
            int min = 0;
            int max = 9;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            #endregion

            int element = 0;
            int globalCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentCount = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentCount++;

                    }
                }

                if (currentCount > globalCount)
                {
                    globalCount = currentCount;
                    element = arr[i];
                }
            }

            #region res

            Console.Write("Array: ");

            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            if (globalCount == 1)
            {
                Console.WriteLine("Няма повторение");
            }
            
            else
            {
                Console.WriteLine("number: {0}", element);
                Console.WriteLine("number of times: {0}", globalCount);
            }
            #endregion





            //int element = 0;
            //int globalCount = 0;

            //foreach (int num in arr)
            //{
            //    int currentCount = 0;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (num == arr[i])
            //        {
            //            currentCount++;
            //        }
            //    }

            //    if (currentCount > globalCount)
            //    {
            //        globalCount = currentCount;
            //        element = num;
            //    }

            //}

            //foreach (var item in arr)
            //{
            //    Console.Write("{0} ", item);
            //}


            //Console.WriteLine(element);
            //Console.WriteLine(globalCount);
        }
    }
}
