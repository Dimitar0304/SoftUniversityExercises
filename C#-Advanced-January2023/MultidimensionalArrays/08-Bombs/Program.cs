using System;
using System.Linq;

namespace _08_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            //at first line we recive nXn diamention of matrix 
            // add their elements sep by single space
            // at last line we recive cordinates with bombs in the matrix and 
            // start iterate by matrix when we met a bomb element the bobm explode:
            //decreace all elements arount it one row-1,row+1,column-1,colum+1,diagonal -1,diagonal+1;
            //if one of these elements it's bomb decrease it 
            // value of exploded bomb become to zero

            //then till the end of matrix
            //after that print  count of alive elements its value is more than 0 
            // print and sum of alive elements .
            // at the end prints the martrix with dead elements ,realy all martix.

            int diamentions = int.Parse(Console.ReadLine());
            int[,] matrix = new int[diamentions, diamentions];

            for (int row = 0; row < diamentions; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < diamentions; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            //corddinates of bombs
            string[] BombsCordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < BombsCordinates.Length; i++)
            {
                string[] currentBomb = BombsCordinates[i].Split(',',StringSplitOptions.RemoveEmptyEntries);
                int currentBombRow = int.Parse(currentBomb[0]);
                int currentBombCol = int.Parse(currentBomb[1]);


                int explodeValue = matrix[currentBombRow, currentBombCol];

                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix.Length; col++)
                    {
                        if (col==currentBombCol && row == currentBombRow&&matrix[currentBombRow,currentBombCol]>0)
                        {
                            matrix[currentBombRow, currentBombCol] = 0;
                            if (row-1 >=0)
                            {
                                if (col-1>=0&& matrix[row - 1, col - 1]>0)
                                {
                                    matrix[row - 1, col - 1] -= explodeValue;
                                }
                                if (col+1<diamentions && matrix[row - 1, col + 1]>0)
                                {
                                    matrix[row - 1, col + 1] -= explodeValue;
                                }
                                if (matrix[row-1,col]>0)
                                {
                                    matrix[row - 1, col] -= explodeValue;
                                }
                            }
                            if (row+1<diamentions)
                            {
                                if (col-1>=0&&matrix[row+1,col-1]>0)
                                {
                                    matrix[row + 1, col - 1] -= explodeValue;
                                }
                                if (col+1<diamentions &&matrix[row+1,col+1]>0)
                                {
                                    matrix[row + 1, col + 1] -= explodeValue;
                                }
                                if (matrix[row+1,col]>0)
                                {
                                    matrix[row + 1, col] -= explodeValue;
                                }
                            }
                            if (col-1>=0&&matrix[row,col-1]>0)
                            {
                                matrix[row, col - 1] -= explodeValue;
                            }
                            if (col+1<diamentions &&matrix[row,col+1]>0)
                            {
                                matrix[row, col + 1] -= explodeValue;
                            }
                        }
                    }
                }
            }
            int countOfAliveCells = 0;
            int sumOfAlivecells = 0;
            //count alive cells
            for (int row = 0; row < diamentions; row++)
            {
                for (int col = 0; col < diamentions; col++)
                {
                    if (matrix[row,col]>0)
                    {
                        countOfAliveCells++;
                        sumOfAlivecells += matrix[row, col];
                    }
                }
                
            }
            Console.WriteLine($"Alive cells: {countOfAliveCells}");
            Console.WriteLine($"Sum: {sumOfAlivecells}");




            //print all matrix
            for (int row = 0; row < diamentions; row++)
            {
                for (int col = 0; col < diamentions; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }

            
        }
    }
}
