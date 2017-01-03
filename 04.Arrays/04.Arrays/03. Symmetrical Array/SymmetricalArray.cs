/*Напишете програма, която проверява дали един масив е симетричен.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Symmetrical_Array
{
    class SymmetricalArray
    {
        static void Main(string[] args)
        {
            //потребителя определя дължината и въвежда масива

            Console.WriteLine("Enter a lenght of array");

            int lenghtArr = int.Parse(Console.ReadLine());

            int[] Array = new int[lenghtArr];

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Give me element og array");

                Array[i] = int.Parse(Console.ReadLine());
            }

            //проверка за симетрия

            bool isSymetrical = true;

            for (int i = 1; i <= (Array.Length / 2); i++)
            {
                if (Array[i] != Array[(Array.Length - i)])
                {
                    isSymetrical = false;
                    break;   //явно не е симетричен и прекъсваме цикъла да не се хаби:-)
                }               
            }

            if (isSymetrical)
            {
                Console.WriteLine("The array is symetrical");
            }
            else
            {
                Console.WriteLine("The array is not symetrical");
            }
        }
    }
}
