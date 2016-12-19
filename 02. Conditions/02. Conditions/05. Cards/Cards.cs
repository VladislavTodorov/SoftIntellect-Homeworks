/*Класическото тесте карти се състои от 13 различни вида карти съответно 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Направете програма, която приема от конзолата един символ и принтира "Валидна карта", ако символът представлява валидна карта, и съответно принтира "Невалидна карта", ако символът е на невалидна карта. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            bool validCard = false;

            string inputCard = Console.ReadLine();

            foreach (var item in cards)
            {
                if (item == inputCard)
                {
                    validCard = true;
                    break;   //така работи по-бързо: ако е намерена "карта" няма смисъл да да довърта цикъла
                }
            }

            if (validCard)
            {
                Console.WriteLine("Valid card");
            }
            else
            {
                Console.WriteLine("Invalid card");
            }
        }
    }
}
