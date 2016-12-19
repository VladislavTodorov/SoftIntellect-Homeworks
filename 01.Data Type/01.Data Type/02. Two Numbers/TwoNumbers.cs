/*Напишете програма, която чете от конзолата 2 числа от тип int и отпечатва тяхната сума.*/

using System;

namespace _02.Two_Numbers
{
    class TwoNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secindNum = int.Parse(Console.ReadLine());

            Console.WriteLine(firstNum + secindNum);
        }
    }
}
