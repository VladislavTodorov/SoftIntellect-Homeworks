/*Направете програма, която приема две цели числа - съответно страните на правоъгълник.
Пресметнете лицето на дадения правоъгълник и я изведете на конзолата.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Face_Of_Rectangle
{
    class FaceOfRectangle
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine(sideA * sideB);
        }
    }
}
