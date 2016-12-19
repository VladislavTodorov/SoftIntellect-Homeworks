/*Направете програма, която чете едно цяло число от конзолата. Ако числото е в интервала от 1 до 5, нека да изписва дали е четно или нечетно. Ако е в интервала от 6 до 15, нека да извежда дали се дели на 3 без остатък.  Ако не попада в споменатите интервали, то нека да ни казва дали е положително, отрицателно или нула.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Example_Of_Lecture
{
    class ExampleOfLectureOne
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if ((num < 1) || (num > 15))
            {
                if (num > 0)
                {
                    Console.WriteLine("positive");
                }
                else if (num < 0)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("zero");
                }
            }
            else
            {
                if ((num >= 1) && (num <= 5))
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("even");
                    }
                    else
                    {
                        Console.WriteLine("odd");
                    }
                }

                else if ((num >= 6) && (num <= 15))
                {
                    if (num % 3 == 0)
                    {
                        Console.WriteLine("yes");
                    }
                    else
                    {
                        double balance = num % 3;
                        Console.WriteLine("no, the balance is: {0}", balance);
                    }
                }
            }

        }
    }
}



