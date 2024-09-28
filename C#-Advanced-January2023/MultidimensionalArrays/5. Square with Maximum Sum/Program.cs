using System;
using System.Linq;
namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //we recive at first line rows and cols for creating a matrix
            //our problem is to find solution for find a square in matrix wich sum is the biggest of squares
            int[] countOfRowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = countOfRowsAndCols[0];
            int cols = countOfRowsAndCols[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            int biggerSum = 0;
            int currentSum = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                currentSum = 0;
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    
                        var newSquareSum = matrix[row, col] +
                       matrix[row, col + 1] +
                       matrix[row + 1, col] +
                       matrix[row + 1, col + 1];
                        currentSum = newSquareSum;
                        if (currentSum > biggerSum)
                        {
                            biggerSum = currentSum;
                            maxRow = row;
                            maxCol = col;
                        }
                   
                    else
                    {
                        continue;
                    }
                   
                }
            }
            Console.WriteLine($"{matrix[maxRow,maxCol]} {matrix[maxRow,maxCol+1]}");
            Console.WriteLine($"{matrix[maxRow+1, maxCol]} {matrix[maxRow+1, maxCol + 1]}");
            Console.WriteLine(biggerSum);
        }
    }
}
