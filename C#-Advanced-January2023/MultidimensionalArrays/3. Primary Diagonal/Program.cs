using System;
using System.Linq;
namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            // find the sum of  two of diagonals to square 
            //first we recive cols and rows  they are equal because this is square matrix
            int squareRowsAndCols = int.Parse(Console.ReadLine());
            int[,] squareMatrix = new int[squareRowsAndCols, squareRowsAndCols];
            //for loop for read elements in matrix of console
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = data[col];
                }
            }

            int diagonalSum = 0;
            //for loop for sum diagonals in sqareMatrix
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                diagonalSum += squareMatrix[row, row];
            }
            Console.WriteLine(diagonalSum);
        //    now for another diagonal
        //    for (int roww = 0; roww < squareMatrix.GetLength(0); roww++)
        //        {
        //            diagonalSum += squareMatrix[roww, roww + 1];
        //        }
        //    Console.WriteLine(diagonalSum);
        }
    }
}
