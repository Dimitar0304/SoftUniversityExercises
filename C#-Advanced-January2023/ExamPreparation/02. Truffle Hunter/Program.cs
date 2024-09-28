using System;
using System.Linq;
namespace _02._Truffle_Hunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfAtenTruffels = 0;
            //first we recive a int for square forest field 
            //second line we recive line by linee it 
            // B = black truffle
            //S = summer truffle
            // W = white truffle
            //- = free space
            // we reciving a command until "Stop the hunt"
            //they maigth be 
            //"Wild_Boar" {row,col} {direction}
            //"Collect" {row,col}
            int blackCounter = 0;
            int summerCounter = 0;
            int whiteCounter = 0;

            int n = int.Parse(Console.ReadLine());

            char[,] forest = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    forest[row, col] = data[col];
                }
            }

            string command = Console.ReadLine();
            while (command!="Stop the hunt")
            {
                string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int currentRow = int.Parse(commandInfo[1]);
                int currentCol = int.Parse(commandInfo[2]);
                if (commandInfo[0] == "Wild_Boar")
                {
                    string direction = commandInfo[3];
                    if (direction=="up")
                    {
                        int counter = 1;
                        for (int row = currentRow; row >= 0; row--)
                        {
                            if (counter % 2 != 0)
                            {


                                if (forest[row, currentCol] == 'B' || forest[row, currentCol] == 'S' || forest[row, currentCol] == 'W')
                                {
                                    countOfAtenTruffels++;
                                    forest[row, currentCol] = '-';
                                }
                            }
                            counter++;
                        }
                    }
                    else if (direction=="down")
                    {
                        int counter = 1;
                        for (int row = currentRow; row < n; row++)
                        {
                            if (counter % 2 != 0)
                            {
                                if (forest[row, currentCol] == 'B' || forest[row, currentCol] == 'S' || forest[row, currentCol] == 'W')
                                {
                                    countOfAtenTruffels++;
                                    forest[row, currentCol] = '-';
                                }
                            }
                            counter++;
                        }
                    }
                    else if (direction == "left")
                    {
                        int counter = 1;
                        for (int col = currentCol; col >= 0; col--)
                        {
                            if (counter % 2 != 0)
                            {
                                if (forest[currentRow, col] == 'B' || forest[currentRow, col] == 'W' || forest[currentRow, col] == 'S')
                                {
                                    countOfAtenTruffels++;
                                    forest[currentRow, col] = '-';
                                }
                            }
                            counter++;
                        }
                    }
                    else if (direction=="right")
                    {
                        int counter = 1;
                        for (int col = currentCol; col < n; col++)
                        {
                            if (counter % 2 != 0)
                            {
                                if (forest[currentRow, col] == 'B' || forest[currentRow, col] == 'W' || forest[currentRow, col] == 'S')
                                {
                                    countOfAtenTruffels++;
                                    forest[currentRow, col] = '-';

                                }
                            }
                            counter++;
                        }
                    }

                }
                else
                {
                    if (currentRow>=0&&currentRow<n&&currentCol>=0&&currentCol<n)
                    {
                        if (forest[currentRow, currentCol] == 'B')
                        {
                            blackCounter++;
                            forest[currentRow, currentCol] = '-';
                        }
                        else if (forest[currentRow, currentCol] == 'S')
                        {
                            summerCounter++;
                            forest[currentRow, currentCol] = '-';
                        }
                        else if (forest[currentRow,currentCol]=='W')
                        {
                            whiteCounter++;
                            forest[currentRow, currentCol] = '-';
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Peter manages to harvest {blackCounter} black, {summerCounter} summer, and {whiteCounter} white truffles.");
            Console.WriteLine($"The wild boar has eaten {countOfAtenTruffels} truffles.");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{forest[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
