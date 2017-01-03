/*Напишете програма, която търси число в масив от числа и връща индекса на първото намерено число.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _07.IndexFirstNumberFound
{
    class IndexFirstNumberFound
    {
        static void Main()
        {
            //*доколкото разбирам условието, ще правя следното:
            // 1.Ще задам масив с произволни числа, например 10 цели числа
            // 2.Потребителя ще въведе число
            // 3.Ако го намери програмата ще му каже индекса
            // 4.Ако го намери повече от веднъж ще каже само първия индекс*/

            int[] randomArr = new int[10];

            //ще зададем минимална и максимална граница на обхвата, защото май само така хващаме отрицателните стойности
            int min = -5;
            int max = 10;

            //пълним с random стойности
            Random rand = new Random();

            for (int i = 0; i < randomArr.Length; i++)
            {                
                randomArr[i] = rand.Next(min, max);
            }

            Console.WriteLine("Which number we look?:");

            //int num = int.Parse(Console.ReadLine());
            //int index = Array.IndexOf(randomArr, num);

            int index = Array.IndexOf(randomArr, int.Parse(Console.ReadLine()));

            //да видим масива
            foreach (var item in randomArr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            
            if (index == (-1))
            {
                Console.WriteLine("Няма");
            }
            else
            {
                Console.WriteLine("The index of value is: {0}", index);
            }
           
        }

    }
}

