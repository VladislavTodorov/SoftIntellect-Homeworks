//Напишете програма, която попълва квадратна матрица спираловидно по посока на часовниковата страна. Потребителя въвежда размерност на матрицата.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Square_Matrix_Spiral
{
    class SquareMatrixSpiral
    {
        static void Main()
        {
            Console.WriteLine("Submit size of the matix:");
            int sizeMat = int.Parse(Console.ReadLine());
            int row = 0;
            int col = sizeMat;

            int[,] matrix = new int[sizeMat, sizeMat];

            int countCol = 0;
            //int countRow = 0;

            for (int i = 0; i < sizeMat; i++)
            {
                for (int j = 0; j < sizeMat; j++)
                {
                    //ако стигмем до последния елемент на първия ред караме надолу                 
                    if (j == (sizeMat - 1))
                    {
                        break;
                    }
                    
                    Console.WriteLine("Enrer element with index {0},{1}:", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    countCol++;


                }

            }


            //отпечатваме я да я видим
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    Console.Write(matrix[k, l]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
