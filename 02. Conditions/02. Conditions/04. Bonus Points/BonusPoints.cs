/*Напишете програма, която изчислява бонус точки на база резултат от игра. Потребителят трябва да въведе своите точки в интервалa[1;9]. Ако точките са в интервала [1;3], добавете 5 към тях. Ако точките са в интервала [4;6], умножете ги по 12. Ако точките са в интервала [7;9], умножете ги по 50 и ги разделете целочислено на 3. Резултатът изведете на екрана.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bonus_Points
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            if ((points >= 1) && (points <= 3))
            {
                points = points + 5;
            }

            else if ((points >= 4) && (points <= 6))
            {
                points *= 12;
            }

            else if ((points >= 7) && (points <= 9))
            {
                points *= 12 / 3;
            }

            Console.WriteLine(points);
        }
    }
}
