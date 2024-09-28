using System;
using System.Linq;
namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //we have to write a program that give us a diffrents of two of diagonals in square matrix of intigers
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            int diff = 0;
            int countOfRowsAndCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[countOfRowsAndCols, countOfRowsAndCols];
            for (int row = 0; row < countOfRowsAndCols; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < countOfRowsAndCols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            //for loop for primaryDiagonal
            for (int row = 0; row < countOfRowsAndCols; row++)
            {
                
                    primaryDiagonal += matrix[row, row];
                
            }
            //for loop for secondaryDiagonal
            for (int row = 0; row < countOfRowsAndCols; row++)
            {
               
                    secondaryDiagonal += matrix[countOfRowsAndCols-row-1,row];
                
            }
            //find the diff
            diff = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(diff);
        }
    }
}
