using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //at the first line we recive n wich is the board of the game matrix
            // square
            // we add to this matrix elements wich will be chars K or O string 
            int countOfRowsAndCols = int.Parse(Console.ReadLine());
            if (countOfRowsAndCols<3)
            {
                Console.WriteLine(0);
                return;
            }
            int[,] matrix = new int[countOfRowsAndCols, countOfRowsAndCols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string boardRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = boardRow[col];
                }
            }
            //the knight can moves to nearest row column or diagonal but not at the same .
            //if one row bellow the K is K remove counterOfKnights ++;
            //if one row bellow and one column more is K counterKnights++;
            int knightsRemoved = 0;
        }
    }
}
