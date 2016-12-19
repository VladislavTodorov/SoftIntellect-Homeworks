using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Variable_Selection
{
    class VariableSelection
    {
        static void Main(string[] args)
        {
            string selection = Console.ReadLine();
            int intNum;
            double doubleNum;

            if (int.TryParse(selection, out intNum))
            {
                intNum += 1;
                Console.WriteLine(intNum);
            } 
                      
            else if (double.TryParse(selection, out doubleNum))
            {
                doubleNum += 1;
                Console.WriteLine(doubleNum);
            }

            else
            {
                Console.WriteLine(selection + "*");
            }
            
        }
    }
}
