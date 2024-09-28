using System;
using System.Linq;
namespace _02._Rally_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            //first line we recive a int count of row and cols of square matrix
            //at second line we recive a number of race car string
            //then we recive each row of matix char separated by single space
            //these char can be a '.' - whitespace
            //'F' - final
            //'T'- tunel we must indicate the tunel cordinates they are always two T at matrix first is begining of tunel,
            //second T is a end of tunel

            //foreach direction that the car recive and move the car move 10 km if it goes thought the tunel it moves 30 km

            //then till the end command we recive a string command  direction up,down,left,right

            //output
            //if we recive end command print "Racing car {racing number} DNF." before car reach the final
            //if the car finiish the race before end command "Racing car {racing number} finished the stage!"
            //on the second line "Distance covered {kilometers passed} km." 
            //at the end print the final state of matrix with the car final move marked with 'C'

            int Square = int.Parse(Console.ReadLine());
            string car = Console.ReadLine();
            char[,] matrix = new char[Square, Square];
            int passedKilometers = 0;
            bool isCarFinished = false;

            int currentRow = 0;
            int currentCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            //initialize the the row and col of the begining of the tunel
            int tunelRow = ReturnTheTunelRow(matrix);
            int tunelCol = ReturnTheTunelCol(matrix);
            matrix[tunelRow, tunelCol] = '.';

            string command = Console.ReadLine();
            while (command != "End")
            {

                //up direction
                if (command == "up")
                {
                    if (currentRow - 1 >= 0)
                    {
                        currentRow--;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            matrix[currentRow, currentCol] = '.';
                            passedKilometers += 10;
                            isCarFinished = true;
                            break;
                        }
                        if (currentRow == tunelRow && currentCol == tunelCol)
                        {
                            //car move thought the tunel
                            int tunelEndRow = ReturnTheTunelRow(matrix);
                            int tunelEndCol = ReturnTheTunelCol(matrix);

                            currentRow = tunelEndRow;
                            currentCol = tunelEndCol;
                            matrix[currentRow, currentCol] = '.';
                            passedKilometers += 30;
                            
                        }
                        else
                        {
                            passedKilometers += 10;
                        }
                       
                    }
                }

               else if (command == "down")
                {
                    if (currentRow + 1 < matrix.GetLength(0))
                    {
                        currentRow++;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            matrix[currentRow, currentCol] = '.';
                            passedKilometers += 10;
                            isCarFinished = true;
                            break;
                        }
                        if (currentRow == tunelRow && currentCol == tunelCol)
                        {
                            //car move thought the tunel
                            int tunelEndRow = ReturnTheTunelRow(matrix);
                            int tunelEndCol = ReturnTheTunelCol(matrix);

                            currentRow = tunelEndRow;
                            currentCol = tunelEndCol;
                            matrix[currentRow, currentCol] = '.';
                            passedKilometers += 30;
                            
                        }
                        else
                        {
                            passedKilometers += 10;
                        }
                        
                    }
                }
               else if (command == "left")
                {
                    if (currentCol - 1 >= 0)
                    {
                        currentCol--;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            matrix[currentRow, currentCol] = '.';
                            isCarFinished = true;
                            passedKilometers += 10;
                            break;
                        }
                        if (currentRow == tunelRow && currentCol == tunelCol)
                        {
                            //car move thought the tunel
                            int tunelEndRow = ReturnTheTunelRow(matrix);
                            int tunelEndCol = ReturnTheTunelCol(matrix);

                            currentRow = tunelEndRow;
                            currentCol = tunelEndCol;
                            matrix[currentRow, currentCol] = '.';
                            passedKilometers += 30;
                            
                        }
                        else
                        {
                            passedKilometers += 10;
                        }
                       
                    }
                }
               else if (command == "right")
                {
                    if (currentCol + 1 < matrix.GetLength(1))
                    {
                        currentCol++;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            matrix[currentRow, currentCol] = '.';
                            passedKilometers += 10;
                            isCarFinished = true;
                            break;
                        }
                        if (currentRow == tunelRow && currentCol == tunelCol)
                        {
                            //car move thought the tunel
                            int tunelEndRow = ReturnTheTunelRow(matrix);
                            int tunelEndCol = ReturnTheTunelCol(matrix);

                            currentRow = tunelEndRow;
                            currentCol = tunelEndCol;
                            matrix[currentRow, currentCol] = '.';
                            passedKilometers += 30;
                            
                        }
                        else
                        {
                            passedKilometers += 10;
                        }
                        
                    }
                }


                if (isCarFinished == true)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (isCarFinished == true)
            {
                Console.WriteLine($"Racing car {car} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {car} DNF.");
            }

            Console.WriteLine($"Distance covered {passedKilometers} km.");
            matrix[currentRow, currentCol] = 'C';
            PrintTheMatix(matrix);
        }

        private static void PrintTheMatix(char[,] matrix)
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

        private static int ReturnTheTunelRow(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'T')
                    {


                        return row;
                    }
                }
            }
            return 0;
        }
        private static int ReturnTheTunelCol(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'T')
                    {


                        return col;
                    }
                }
            }
            return 0;
        }
    }
}
