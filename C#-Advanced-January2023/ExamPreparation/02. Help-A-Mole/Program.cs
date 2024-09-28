using System;

namespace _02._Help_A_Mole
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldRowAndCol = int.Parse(Console.ReadLine());
            int points = 0;

            char[,] field = new char[fieldRowAndCol, fieldRowAndCol];

            for (int row = 0; row < fieldRowAndCol; row++)
            {
                string data = Console.ReadLine();
                for (int col = 0; col < fieldRowAndCol; col++)
                {
                    field[row, col] = data[col];
                }
            }
            int currentRow = 0;
            int currentCol = 0;
            //initialize where is the startPosition ,row and cols 
            for (int row = 0; row < fieldRowAndCol; row++)
            {

                for (int col = 0; col < fieldRowAndCol; col++)
                {
                    if (field[row, col] == 'M')
                    {
                        field[row, col] = '-';
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            string command = Console.ReadLine();
            while (points < 25 && command != "End")
            {
                switch (command)
                {
                    case "up":
                        if (currentRow-1 >=0)
                        {
                            currentRow--;
                            string curentChar = field[currentRow, currentCol]+" ";
                            if (char.IsDigit(field[currentRow, currentCol]))
                            {
                                int currentPoints = Convert.ToInt32(curentChar);
                                points += currentPoints;
                                field[currentRow, currentCol] = '-';
                            }
                            else if (field[currentRow, currentCol] == 'S')
                            {
                                field[currentRow, currentCol] = '-';
                                //Mole teleports
                                currentRow = ReturnTheSpecialCharRow(field);
                                currentCol = ReturnTheSpecialCharCol(field);
                                field[currentRow, currentCol] = '-';
                                points -= 3;

                            }
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                    case "right":
                        if (currentCol+1<fieldRowAndCol)
                        {
                            currentCol++;
                            string curentChar = field[currentRow, currentCol]+" ";
                            if (char.IsDigit(field[currentRow,currentCol]))
                            {
                                int currentPoints = int.Parse(curentChar);
                                points += currentPoints;
                                field[currentRow, currentCol] = '-';
                            }
                            else if (field[currentRow, currentCol]=='S')
                            {
                                field[currentRow, currentCol] = '-';
                                //Mole teleports
                                currentRow = ReturnTheSpecialCharRow(field);
                                currentCol = ReturnTheSpecialCharCol(field);
                                points -= 3;
                                field[currentRow, currentCol] = '-';

                            }
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                    case "left":
                        if (currentCol-1 >=0)
                        {
                            currentCol--;
                            string curentChar = field[currentRow, currentCol]+" ";
                            if (char.IsDigit(field[currentRow, currentCol]))
                            {
                                int currentPoints = Convert.ToInt32(curentChar);
                                points += currentPoints;
                                field[currentRow, currentCol] = '-';
                            }
                            else if (field[currentRow, currentCol] == 'S')
                            {
                                field[currentRow, currentCol] = '-';
                                //Mole teleports
                                currentRow = ReturnTheSpecialCharRow(field);
                                currentCol = ReturnTheSpecialCharCol(field);
                                points -= 3;
                                field[currentRow, currentCol] = '-';
                            }
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                    case "down":
                        if (currentRow+1<fieldRowAndCol)
                        {
                            currentRow++;
                            string curentChar = field[currentRow, currentCol] + " ";
                            if (char.IsDigit(field[currentRow, currentCol]))
                            {
                                int currentPoints = Convert.ToInt32(curentChar);
                                points += currentPoints;
                                field[currentRow, currentCol] = '-';
                            }
                            else if (field[currentRow, currentCol] == 'S')
                            {
                                field[currentRow, currentCol] = '-';
                                //Mole teleports
                                currentRow = ReturnTheSpecialCharRow(field);
                                currentCol = ReturnTheSpecialCharCol(field);
                                points -= 3;
                                field[currentRow, currentCol] = '-';
                            }
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            if (points >= 25)
            {
                Console.WriteLine($"Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            }

            field[currentRow, currentCol] = 'M';

            PrintTheField(field);


           
            int ReturnTheSpecialCharRow(char[,] field)
            {
                for (int row = 0; row < field.GetLength(0); row++)
                {

                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        if (field[row, col] == 'S')
                        {
                            return row;
                        }
                    }
                }
                return 0;
            }
            int ReturnTheSpecialCharCol(char[,] field)
            {
                for (int row = 0; row < field.GetLength(0); row++)
                {

                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        if (field[row, col] == 'S')
                        {
                            return col;
                        }
                    }
                }
                return 0;
            }
            void PrintTheField(char[,] field)
            {
                for (int row = 0; row < field.GetLength(0); row++)
                {

                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        Console.Write(field[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }


    }
}
