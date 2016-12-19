using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cards_swich_case
{
    class CardsSwichCase
    {
        static void Main(string[] args)
        {
            string inputCard = Console.ReadLine();

            switch (inputCard)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":

                    Console.WriteLine("Valid card");
                    break;

                default:
                    Console.WriteLine("Invalid card");
                    break;
            }
        }
    }
}
