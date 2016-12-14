
/*Напишете програма, която приема два стринга като вход. След това проверява дали 2рия стринг се съдържа в 1вия. Покажете резултата от проверката на конзолата. *
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Two_Strings_
{
    class TwoStrings
    {
        static void Main(string[] args)
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();

            bool isTrue = false;

            for (int i = 0; i < firstStr.Length; i++)
            {
                //сега: ако първия елемент от втория стринг съвпада с "i"-тия елемент на първия стринг И втория стринг не е по-дълъг от остатъка до края на първия стринг

                //if ((firstStr[i] == secondStr[0]) &&
                //((firstStr.Length - firstStr[i]) == secondStr.Length))

                if ((firstStr[i] == secondStr[0]))
                {
                    if ((firstStr.Length - firstStr[i]) == secondStr.Length)
                    {
                        Console.WriteLine("ura");
                    }
                }
                //има смисъл да проверяваме нататъка
                {
                    for (int j = 1; j < secondStr.Length; j++)
                    {
                        if (firstStr[i + 1] == secondStr[j])
                        {
                            isTrue = true;
                        }
                    }
                }
            }

            Console.WriteLine(isTrue);
        }
    }
}


  
