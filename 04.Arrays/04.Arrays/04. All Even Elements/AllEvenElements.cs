/*Напишете програма, която намира сбора на всичките четни елементи в масив.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.All_Even_Elements
{
    class AllEvenElements
    {
        static void Main(string[] args)
        {
            #region потребителя определя дължината и въвежда масива            

            Console.WriteLine("Enter a lenght of array");

            int lenghtArr = int.Parse(Console.ReadLine());

            int[] Array = new int[lenghtArr];

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Give me element og array");
                Array[i] = int.Parse(Console.ReadLine());
            }
            #endregion

            int sumEven = 0;
            foreach (var item in Array)
            {
                if (item % 2 == 0)
                {
                    sumEven += item;
                }
            }

            Console.WriteLine(sumEven);
        }
    }
}
