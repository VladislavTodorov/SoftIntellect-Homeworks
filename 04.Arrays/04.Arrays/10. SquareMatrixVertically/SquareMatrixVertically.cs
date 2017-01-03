/*Напишете програма, която попълва квадратна матрица: първо вертикално, след това хоризонтално. Потребителя въвежда размерност на матрицата.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SquareMatrixVertically
{
    class SquareMatrixVertically
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Submit size of the matix:");
            int row = int.Parse(Console.ReadLine());           
            int col = row;

            //размерност на матрицата
            int[,] matrix = new int[row, col];

            Random rant = new Random();
            int min = 1;
            int max = 9;

            //пълним я "първо вертикално" с произвилни стойности за да спестим труда на потребителя

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = rant.Next(min,max);
                }
            }

            //отпечатваме я да я видим

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //след това стойностите на същата матрица ги записваме в друга като редовете стават колони
            int[,] matrixInvert = new int[row,col];

            for (int i = 0; i < matrixInvert.GetLength(0); i++)
            {
                for (int j = 0; j < matrixInvert.GetLength(0); j++)
                {
                    matrixInvert[i, j] = matrix[j, i];
                }
            }

            //отпечатваме я да я видим

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrixInvert[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
