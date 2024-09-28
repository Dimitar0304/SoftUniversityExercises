using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] RowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = RowsAndCols[0];
            int cols = RowsAndCols[1];
            int sumOfMatrix = 0;

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); 
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int curentNumber = matrix[row, col];
                    sumOfMatrix += curentNumber;
                    
                }

            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sumOfMatrix);
        }
    }
}
