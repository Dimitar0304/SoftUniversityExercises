using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            //we must to add elements to matrix with given string wich string is snake path
            // if snake path end we start from beggging 
            int[] dimationOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimationOfMatrix[0];
            int cols = dimationOfMatrix[1];

            string snake = Console.ReadLine();
            int counter = 0;
            char[,] matrix = new char[rows, cols];
            char[] snakePath = snake.ToCharArray();
            for (int row = 0; row < rows; row++)
            {

                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (counter == snakePath.Length)
                        {
                            
                            counter = 0;
                        }
                        matrix[row, col] = snakePath[counter];
                        counter++;
                        
                    }
                }
                else
                {

                    for (int col = cols - 1; col >= 0; col--)
                    {
                       
                        if (counter == snakePath.Length)
                        {
                            
                            counter = 0;
                        }
                        matrix[row, col] = snakePath[counter];
                        counter++;
                    }
                }
            }

                for (int row = 0; row < rows; row++)
                {

                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }

