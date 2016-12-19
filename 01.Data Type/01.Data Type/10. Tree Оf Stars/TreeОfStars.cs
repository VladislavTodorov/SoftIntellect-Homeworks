/*Напишете програма, която принтира фигура във формата на борче със знака "o".*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tree_Оf_Stars
{
    class TreeОfStars
    {
        static void Main(string[] args)
        { 
            int boughs = int.Parse(Console.ReadLine());

            int star = 1;
            int space = (boughs - 1);

            for (int i = 0; i < boughs; i++)
            {
                Console.Write(new string(' ', space));
                Console.WriteLine(new string('*', star));

                space--;
                star += 2;
            }
        }
    }
}
