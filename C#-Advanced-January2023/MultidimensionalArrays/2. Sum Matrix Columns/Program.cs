using System;
using System.Linq;
namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            //we have array wwe have to split it and get rows and cols for creating new matrix
            //we create matrix and readOfConsole their elements by single space
            // foreach column in matrix we have to print their sum

            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int[rows, cols];

            // for loop for read matrix elements of console
            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            int currentColumnSum = 0;
            //for loop for sum each column element
            for (int col = 0; col < cols; col++)
            {
                currentColumnSum = 0;
                for (int row = 0; row < rows; row++)
                {
                    currentColumnSum += matrix[row, col];
                }
                Console.WriteLine(currentColumnSum);
            }
        }
    }
}
