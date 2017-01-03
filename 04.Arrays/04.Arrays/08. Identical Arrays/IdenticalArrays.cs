/*Да се напише програма, която чете два масива от конзолата и проверява дали са еднакви.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Identical_Arrays
{
    class IdenticalArrays
    {
        static void Main(string[] args)
        {
            //за по-лесно няма да въвеждаме елементите един по един

            Console.WriteLine("Give the values for the first array in one line, separated by space;");
            string[] firstArr = Console.ReadLine().Split();            

            Console.WriteLine("Give values for the first array in one line, separated by space;");
            string[] secondArr = Console.ReadLine().Split();


            bool isSame = true;

            if (firstArr.Length != secondArr.Length)
            {
                isSame = false;
            }
            else
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] != secondArr[i])
                    {
                        isSame = false;
                    }
                }
            }


            if (isSame)
            {
                Console.WriteLine("the same");                
            }
            else
            {
                Console.WriteLine("not the same");
            }
        }
    }
}
