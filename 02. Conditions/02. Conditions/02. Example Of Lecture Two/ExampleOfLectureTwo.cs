/*Напишете програма, която за дадена цифра (0-9), зададена като вход, извежда името на цифрата на български език.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Example_Of_Lecture_Two
{
    class ExampleOfLectureTwo
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.WriteLine("нула");
                    break;
                case 1:
                    Console.WriteLine("едно");
                    break;
                case 2:
                    Console.WriteLine("две");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                case 4:
                    Console.WriteLine("четири");
                    break;
                case 5:
                    Console.WriteLine("пет");
                    break;
                case 6:
                    Console.WriteLine("шест");
                    break;
                case 7:
                    Console.WriteLine("седем");
                    break;
                case 8:
                    Console.WriteLine("осем");
                    break;
                case 9:
                    Console.WriteLine("девет");
                    break;

                default: break;
            }
        }
    }
}
