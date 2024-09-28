using System;
using System.Linq;
namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //first line we recive rows and cols of matrix
            // at n lines we recive chars we add them with their ascci code to matrix
            //after that we recive a symbol 
            // we must iterate in matrix and try to find symbol 
            // if symbol consist print his location like [row , col]
            //if we can't find print "{symbol} does not occur in the matrix".
            int countOfRowsAndCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[countOfRowsAndCols, countOfRowsAndCols];
            //for loop for adding elements in matrix.
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string data = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = (int)data[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            //for loop for indicate is symbol in matrix.
            bool isSymbolISInMatrix = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    if ((char)matrix[row, col]== symbol)
                    {
                        isSymbolISInMatrix = true;
                        Console.WriteLine($"({row}, {col})");
                    }
                   
                }
            }
            if (isSymbolISInMatrix==false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
