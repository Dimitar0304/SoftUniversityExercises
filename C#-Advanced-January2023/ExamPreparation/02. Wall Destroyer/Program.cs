using System;

namespace _02._Wall_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentRow = 0;
            int currentCol = 0;

            int coutOfRods = 0;
            int holeCounter = 0;

            bool isVankoElectreecuted = false;

            int countOfRowAndCols = int.Parse(Console.ReadLine());

            char[,] wall = new char[countOfRowAndCols, countOfRowAndCols]; 

            for (int row = 0; row < countOfRowAndCols; row++)
            {
                string data = Console.ReadLine();
                for (int col = 0; col < countOfRowAndCols; col++)
                {
                    wall[row, col] = data[col];
                }
            }
            //for iniitialize the start possition
            for (int row = 0; row < countOfRowAndCols; row++)
            {
                
                for (int col = 0; col < countOfRowAndCols; col++)
                {
                    if (wall[row,col]=='V')
                    {
                        currentRow = row;
                        currentCol = col;
                        wall[row, col] = '*';
                        holeCounter++;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
               

                if (command=="up"&&currentRow-1>=0)
                {
                   
                    currentRow--;

                    if (wall[currentRow,currentCol]=='R')
                    {
                        currentRow++;
                        coutOfRods++;
                        Console.WriteLine("Vanko hit a rod!");
                    }
                     else if (wall[currentRow,currentCol]=='C')
                    {
                        isVankoElectreecuted = true;
                        wall[currentRow, currentCol] = 'E';
                        holeCounter++;
                        break;
                    }
                     else if (wall[currentRow,currentCol]=='*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentCol}]!");
                        
                    }
                    else if (wall[currentRow,currentCol]=='-')
                    {
                        wall[currentRow, currentCol] = '*';
                        holeCounter++;
                    }




                }
                else if (command =="down"&&currentRow+1 <countOfRowAndCols)
                {
                    currentRow++;
                    if (wall[currentRow, currentCol] == 'R')
                    {
                        currentRow--;
                        coutOfRods++;
                        Console.WriteLine("Vanko hit a rod!");
                    }
                   else  if (wall[currentRow, currentCol] == 'C')
                    {
                        isVankoElectreecuted = true;
                        wall[currentRow, currentCol] = 'E';
                        holeCounter++;
                        break;
                    }
                    else if (wall[currentRow, currentCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentCol}]!");
                        
                    }
                    else if (wall[currentRow, currentCol] == '-')
                    {
                        wall[currentRow, currentCol] = '*';
                        holeCounter++;
                    }


                }
                else if (command=="left"&&currentCol -1  >=0)
                {
                    currentCol--;

                    if (wall[currentRow, currentCol] == 'R')
                    {
                        currentCol++;
                        coutOfRods++;
                        Console.WriteLine("Vanko hit a rod!");
                    }
                    else if (wall[currentRow, currentCol] == 'C')
                    {
                        isVankoElectreecuted = true;
                        wall[currentRow, currentCol] = 'E';
                        holeCounter++;
                        break;
                    }
                    else if (wall[currentRow, currentCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentCol}]!");
                        
                    }
                     else  if (wall[currentRow, currentCol] == '-')
                    {
                        wall[currentRow, currentCol] = '*';
                        holeCounter++;
                    }


                }
                else if (command =="right"&&currentCol+1 < countOfRowAndCols)
                {
                    currentCol++;

                    if (wall[currentRow, currentCol] == 'R')
                    {
                        currentCol--;
                        coutOfRods++;
                        Console.WriteLine("Vanko hit a rod!");
                    }
                    else if (wall[currentRow, currentCol] == 'C')
                    {
                        isVankoElectreecuted = true;
                        wall[currentRow, currentCol] = 'E';
                        holeCounter++;
                        break;
                    }
                    else if (wall[currentRow, currentCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentCol}]!");
                        
                    }
                   else  if (wall[currentRow, currentCol] == '-')
                    {
                        wall[currentRow, currentCol] = '*';
                        holeCounter++;
                    }


                }
                command = Console.ReadLine();
            }

            if (isVankoElectreecuted==true)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCounter} hole(s).");
            }
            else
            {
                wall[currentRow, currentCol] = 'V';
                Console.WriteLine($"Vanko managed to make {holeCounter} hole(s) and he hit only {coutOfRods} rod(s).");
            }

            PrintField(wall);
        }

        private static void PrintField(char[,] wall)
        {
            for (int row = 0; row < wall.GetLength(0); row++)
            {
                
                for (int col = 0; col < wall.GetLength(1); col++)
                {
                    Console.Write(wall[row,col]); 
                }
                Console.WriteLine();
            }
        }
    }
}
