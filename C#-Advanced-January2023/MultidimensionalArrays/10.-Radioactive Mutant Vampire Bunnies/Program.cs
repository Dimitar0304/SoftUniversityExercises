using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isThePlayerDied = false;
            //first we recive row and cols of the lair in one line 
            //then we recive string with these chars'.','B' or'P'
            //where '.' empty space, B is a bunny and P is a player in matrix has only one P
            //after that we recive a string with directions wich is up,right,left,down
            //after each command of the player, all of bunnies spread of all '.' spaces become to B
            //if bunny reaches player he died and if player reach b cells also he died 
            //if commands become to end and player is still alive he escape from Lair  
            //after that print the matrix 
            //and if player is won or died + his cordinates

            int[] countOfRowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = countOfRowsAndCols[0];
            int cols = countOfRowsAndCols[1];

            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string LairLine = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = LairLine[col];
                }
            }

            int startRow = 0;
            int startCol = 0;
            int currentRow = 0;
            int currentCol = 0;


            //indicate where player is 
            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'P')
                    {

                        startRow = row;
                        startCol = col;
                    }
                }
            }
            currentRow = startRow;
            currentCol = startCol;


            string commands = Console.ReadLine();
            Queue<char> commandBox = new Queue<char>(commands);
            
            while (commandBox.Count!=0&&isThePlayerDied!=true)
            {
                char currentCommand = commandBox.Dequeue();
                //command is Up
                if (currentCommand == 'U' && currentRow - 1 >= 0)
                {
                    matrix[currentRow, currentCol] = '.';
                    currentRow--;
                    if (matrix[currentRow , currentCol] == 'B')
                    {
                        matrix[currentRow, currentCol] = 'B';
                        isThePlayerDied = true;
                        
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = 'P';
                    }
                }

                //command is Down
                else if (currentCommand == 'D' && currentRow + 1 < matrix.GetLength(0))
                {
                    matrix[currentRow, currentCol] = '.';
                    currentRow++;
                    if (matrix[currentRow , currentCol] == 'B')
                    {
                        matrix[currentRow, currentCol] = 'B';
                        isThePlayerDied = true;
                        
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = 'P';
                    }
                }
                //command is Left
                else if (currentCommand == 'L' &&  currentCol - 1 >= 0)
                {
                    matrix[currentRow, currentCol] = '.';
                    currentCol--;
                    if (matrix[currentRow, currentCol ] == 'B')
                    {
                        matrix[currentRow, currentCol] = 'B';
                        isThePlayerDied = true;
                       
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = 'P';
                    }
                }
                //command is right
                else if (currentCommand == 'R' &&  currentCol+1 < matrix.GetLength(1))
                {
                    matrix[currentRow, currentCol] = '.';
                    currentCol++;
                    if (matrix[currentRow, currentCol ] == 'B')
                    {
                        matrix[currentRow, currentCol] = 'B';
                        isThePlayerDied = true;
                      
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = 'P';
                    }
                   
                }
               
                     matrix = BunniesSpread(matrix, isThePlayerDied);
                

               
                
            }
            matrix[currentRow, currentCol] = '.';

            PrintLair(matrix);
            if (isThePlayerDied != true)
            {
               
                Console.WriteLine($"won: {currentRow} {currentCol}");
            }
            else
            {
                Console.WriteLine($"dead: {currentRow} {currentCol}");
            }
            
        }

       
        
       
        public  static char[,] BunniesSpread(char[,] matrix, bool isThePlayerDied)
        {

            char[,] newMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    newMatrix[row, col] = matrix[row, col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (row > 0) //up
                        {
                            newMatrix[row - 1, col] = 'B';
                        }
                        if (row < matrix.GetLength(0) - 1) //down
                        {
                            newMatrix[row + 1, col] = 'B';
                        }
                        if (col > 0) //left
                        {
                            newMatrix[row, col - 1] = 'B';
                        }
                        if (col < matrix.GetLength(1) - 1) //right
                        {
                            newMatrix[row, col + 1] = 'B';
                        }


                    }
                   
               

                }
            }

            return newMatrix;
        }

        public static void PrintLair(char[,]matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
