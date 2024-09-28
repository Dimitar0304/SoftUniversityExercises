using System;
using System.Linq;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] field = new char[tokens[0], tokens[1]];
            int madeMoves = 0;
            int touchedOponents = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = data[col];
                }
            }

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
               
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row,col]=='B')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command!= "Finish")
            {
                if (touchedOponents==3)
                {
                    break;
                }
                if (command=="up")
                {
                    if (IsSafe(field,playerRow-1,playerCol)&&field[playerRow-1,playerCol]!='O')
                    {
                        playerRow--;
                        madeMoves++;
                        if (field[playerRow,playerCol]=='P')
                        {
                            field[playerRow, playerCol] = '-';
                            touchedOponents++;
                            
                        }
                        
                        
                    }
                   
                }
                else if (command=="down")
                {
                    if (IsSafe(field, playerRow +1, playerCol) && field[playerRow + 1, playerCol] != 'O')
                    {
                        playerRow++;
                            madeMoves++;
                        if (field[playerRow, playerCol] == 'P')
                        {
                            field[playerRow, playerCol] = '-';
                            touchedOponents++;
                        }
                        
                        
                    }
                   
                }
                else if (command=="left")
                {
                    if (IsSafe(field, playerRow , playerCol-1) && field[playerRow , playerCol-1] != 'O')
                    {
                        playerCol--;
                            madeMoves++;
                        if (field[playerRow, playerCol] == 'P')
                        {
                            field[playerRow, playerCol] = '-';
                            touchedOponents++;
                        }
                        
                       
                    }
                   
                }
                else if (command=="right")
                {
                    if (IsSafe(field, playerRow , playerCol+1) && field[playerRow , playerCol+1] != 'O')
                    {
                        playerCol++;
                            madeMoves++;
                        if (field[playerRow, playerCol] == 'P')
                        {
                            field[playerRow, playerCol] = '-';
                            touchedOponents++;
                        }
                        
                        
                    }
                   
                }




                command = Console.ReadLine();
            }

            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touchedOponents} Moves made: {madeMoves}");

            bool IsSafe(char[,] field, int playerRow, int playerCol)
            {
                if (playerRow>=0&&playerRow<field.GetLength(0)&&playerCol>=0&&playerCol<field.GetLength(1))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
