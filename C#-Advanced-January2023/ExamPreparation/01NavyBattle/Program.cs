using System;

namespace _01NavyBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int submarineHealth = 3;
            int crusiersAmount = 3;
            //we have submarine u-9 
            //we recive a n int wich is square of submarine battleField
            //it starts in random position 
            //battleField is a matrix of chars 
            //'-' is a empty space
            //'*' is a mine space sbmarine can withstand two hits of these mines third will destroy it and mission falid
            //"Mission failed, U-9 disappeared! Last known coordinates [{row}, {col}]!"

            //we recive a directions 

            int rowsAndCols = int.Parse(Console.ReadLine());

            char[,] battleField = new char[rowsAndCols, rowsAndCols];

            for (int row = 0; row < rowsAndCols; row++)
            {
                string data = Console.ReadLine();
                for (int col = 0; col < rowsAndCols; col++)
                {
                    battleField[row, col] = data[col];
                }
            }

            int currentRow = 0;
            int currentCol = 0;

            //find the submarine position
            for (int row = 0; row < rowsAndCols; row++)
            {
               
                for (int col = 0; col < rowsAndCols; col++)
                {
                    if (battleField[row,col]=='S')
                    {
                        currentRow = row;
                        currentCol = col;
                        break;
                    }
                }
            }

            battleField[currentRow, currentCol] = '-';
            while (crusiersAmount!=0&&submarineHealth!=0)
            {
                string command = Console.ReadLine();
                //if command is Up
                if (command=="up"&&currentRow-1>=0)
                {
                    currentRow--;
                    if (battleField[currentRow,currentCol]=='*')
                    {
                        battleField[currentRow, currentCol] = '-';
                        submarineHealth--;
                    }
                    else if (battleField[currentRow, currentCol]=='C')
                    {
                        battleField[currentRow, currentCol] = '-';
                        crusiersAmount--;
                    }
                }
                //if command is down
                else if (command=="down"&&currentRow+1<battleField.GetLength(0))
                {
                    currentRow++;
                    if (battleField[currentRow, currentCol] == '*')
                    {
                        battleField[currentRow, currentCol] = '-';
                        submarineHealth--;
                    }
                    else if (battleField[currentRow, currentCol] == 'C')
                    {
                        battleField[currentRow, currentCol] = '-';
                        crusiersAmount--;
                    }
                }
                //if command is left
                else if (command=="left"&&currentCol-1>=0)
                {
                    currentCol--;
                    if (battleField[currentRow, currentCol] == '*')
                    {
                        battleField[currentRow, currentCol] = '-';
                        submarineHealth--;
                    }
                    else if (battleField[currentRow, currentCol] == 'C')
                    {
                        battleField[currentRow, currentCol] = '-';
                        crusiersAmount--;
                    }
                }
                //if command is right
                else if (command =="right"&&currentCol+1<battleField.GetLength(1))
                {
                    currentCol++;
                    if (battleField[currentRow, currentCol] == '*')
                    {
                        battleField[currentRow, currentCol] = '-';
                        submarineHealth--;
                    }
                    else if (battleField[currentRow, currentCol] == 'C')
                    {
                        battleField[currentRow, currentCol] = '-';
                        crusiersAmount--;
                    }
                }
                else
                {
                    continue;
                }

            }

            battleField[currentRow, currentCol] = 'S';

            if (crusiersAmount>0)
            {
                //mission faild
                Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{currentRow}, {currentCol}]!");
            }
            else
            {
                Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
            }
            PrintBattleField(battleField);
        }
        public static void PrintBattleField(char[,] battlefield)
        {
            for (int row = 0; row < battlefield.GetLength(0); row++)
            {
                for (int col = 0; col < battlefield.GetLength(1); col++)
                {
                    Console.Write(battlefield[row,col]);
                }
                Console.WriteLine();
            }

        }
    }
    
}
