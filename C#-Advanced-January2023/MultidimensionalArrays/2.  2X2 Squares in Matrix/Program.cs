using System;
using System.Linq;

namespace _2.__2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // at first line we recive rows and cols to creating a matrix
            // at next rows lines we recive a line with chars sep by space add them to currentColumn
            //find the count of the 2x2 squares wich all chars are equal
            int[] matrixDiamentions = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select( n=> int.Parse(n)).ToArray();
            int rows = matrixDiamentions[0];
            int cols = matrixDiamentions[1];
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] charData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(n => char.Parse(n)).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = charData[col];
                }
            }
            int equalSquareCounter = 0;
            //for loop for find the 2x2 squares
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                  
                    if (matrix[row,col] == matrix[row , col+1]&& matrix[row, col] == matrix[row + 1, col + 1]&&matrix[row,col]==matrix[row+1,col])
                    {
                        equalSquareCounter++;
                    }
                    
                   

                }
            }
            Console.WriteLine(equalSquareCounter);
        }
    }
}
