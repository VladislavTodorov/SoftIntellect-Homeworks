/*Напишете проргама която приема 2 целочислени числа за вход и извежда остатъка от делението на числата.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Div_Of_Two_Num
{
    class DivOfTwoNum
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(firstNum % secondNum);
        }
    }
}
