using System;
using System.Linq;

namespace _9.__Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            //we have a miner game wich is in matrix of chars sep by " ",
            //it is square matrix row ==col - first line of input

            //after add elements to matrix we recive a commands string[] sep by " "
            //up down right left =>up=row+1,down=row-1,right = col+1,left=col-1

            //in matrix has one of these three symbols '*'-regular position on the field
            //'c' - wich means coal when miner is on it it collect coal and the cell become to *
            //'e' - which means  when miner is on  it  =>end of the program 
            //'s' - start of miner game

            //cases when program end and print something
            //when miner collect all coals in matrix=>"You collected all coals! ({rowIndex}, {colIndex})".
            //when miner step on 'e' =>"Game over! ({rowIndex}, {colIndex})".
            //when is not one of these cases and no more commands to move=>"{remainingCoals} coals left. ({rowIndex}, {colIndex})".

            int rowsAndCols = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowsAndCols, rowsAndCols];
            //for indicate the field
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int row = 0; row < rowsAndCols; row++)
            {
                char[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < rowsAndCols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            int startRowIndex = 0;
            int startColIndex = 0;
            int currentRowIndex = 0;
            int currentColIndex = 0;
            //for indicate where is the miner start
            for (int row = 0; row < rowsAndCols; row++)
            {
                for (int col = 0; col < rowsAndCols; col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        startRowIndex = row;
                        startColIndex = col;
                        currentRowIndex = startRowIndex;
                        currentColIndex = startColIndex;
                    }
                }
            }




            for (int command = 0; command < commands.Length; command++)
            {
                string currentCommand = commands[command];
                if (IsAnyCoalInMatrix(matrix) == false)
                {
                    Console.WriteLine($"You collected all coals! ({currentRowIndex}, {currentColIndex})");
                    return;
                }
                else
                {

                    if (currentCommand == "up" && currentRowIndex - 1 >= 0)
                    {
                        currentRowIndex = currentRowIndex - 1;

                        //checks for symbol on that indexes
                        if (matrix[currentRowIndex, currentColIndex] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRowIndex}, {currentColIndex})");
                            return;
                        }
                        if (matrix[currentRowIndex, currentColIndex] == 'c' && IsAnyCoalInMatrix(matrix) == true)
                        {
                            matrix[currentRowIndex, currentColIndex] = '*';
                        }




                    }
                    else if (currentCommand == "down" && currentRowIndex + 1 < rowsAndCols)
                    {
                        currentRowIndex = currentRowIndex + 1;

                        //checks for symbol on that indexes
                        if (matrix[currentRowIndex, currentColIndex] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRowIndex}, {currentColIndex})");
                            return;
                        }
                        if (matrix[currentRowIndex, currentColIndex] == 'c' && IsAnyCoalInMatrix(matrix) == true)
                        {
                            matrix[currentRowIndex, currentColIndex] = '*';
                        }



                    }
                    else if (currentCommand == "right" && currentColIndex + 1 < rowsAndCols)
                    {

                        currentColIndex = currentColIndex + 1;
                        //checks for symbol on that indexes
                        if (matrix[currentRowIndex, currentColIndex] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRowIndex}, {currentColIndex})");
                            return;
                        }
                        if (matrix[currentRowIndex, currentColIndex] == 'c' && IsAnyCoalInMatrix(matrix) == true)
                        {
                            matrix[currentRowIndex, currentColIndex] = '*';
                        }
                    }
                    else if (currentCommand == "left" && currentColIndex - 1 >= 0)
                    {

                        currentColIndex = currentColIndex - 1;
                        //checks for symbol on that indexes
                        if (matrix[currentRowIndex, currentColIndex] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRowIndex}, {currentColIndex})");
                            return;
                        }
                        if (matrix[currentRowIndex, currentColIndex] == 'c' && IsAnyCoalInMatrix(matrix) == true)
                        {
                            matrix[currentRowIndex, currentColIndex] = '*';
                        }

                    }

                }

                //for loop for start the game iterate throught the field

                //checks for commands

            }
            int coalRemaiing = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        coalRemaiing++;
                    }
                }

            }

            if (coalRemaiing==0)
            {
                Console.WriteLine($"You collected all coals! ({currentRowIndex}, {currentColIndex})");
            }
            else
            {
                Console.WriteLine($"{coalRemaiing} coals left. ({currentRowIndex}, {currentColIndex})");

            }
           
        }



        public static bool IsAnyCoalInMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
