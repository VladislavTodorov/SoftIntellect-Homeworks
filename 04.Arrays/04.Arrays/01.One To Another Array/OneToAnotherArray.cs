/*Прекопирайте един масив от цели числа в друг масив. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.One_To_Another_Array
{
    class OneToAnotherArray
    {
        static void Main(string[] args)
        {
            //идеята е потребителя да определи дължината и да въведе първия масив
            Console.WriteLine("Enter a lenght of array");

            int lenghtArr = int.Parse(Console.ReadLine());

            int[] firstArr = new int[lenghtArr];

            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.WriteLine("Give me element og array");
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            //първия масив е готов, да го покажем
            Console.Write("The first array is: ");

            foreach (var item in firstArr)
            {
                Console.Write("{0} ",item);
            }

            Console.WriteLine();

            //правим втори масив и му задаваме дължината и стойностите на първия
            int[] secondArr = firstArr;

            //показваме го
            Console.Write("The second array is: ");

            foreach (var item in secondArr)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

        }
    }
}
