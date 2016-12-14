/*Напишете булев израз, който да проверява дали даден низ от символи (string) е равен на „Hello World”. Отпечатайте в конзолата резултата от проверката.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Boolean_Expression
{
    class BooleanExpression
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool isTrue;

            isTrue = (str == "Hello World");

            Console.WriteLine(isTrue);
        }
    }
}
