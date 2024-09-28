using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
             
            //we have rectrangle and reccive rows and cols
            //we have to find the biggest sum of square 3x3 in this rectrangle and print 3x3 elements and sum
            int[] countOfRowsAndCols = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = countOfRowsAndCols[0];
            int cols = countOfRowsAndCols[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            // for loop for finding
            int maxRow = 0;
            int maxCol = 0;
            
            int currentSquareSum = 0;
            int biggestSquareSum = int.MinValue;
            for (int row = 0; row < rows-2; row++)
            {
                for (int col = 0; col < cols-2; col++)
                {
                    currentSquareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSquareSum > biggestSquareSum)
                    {
                        biggestSquareSum = currentSquareSum;
                        maxRow = row;
                        maxCol = col;
                    }

                }
            }
            Console.WriteLine($"Sum = {biggestSquareSum}");
            for (int rowS = maxRow; rowS < maxRow+3; rowS++)
            {
                for (int colS = maxCol; colS < maxCol+3; colS++)
                {
                    Console.Write($"{matrix[rowS,colS]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
