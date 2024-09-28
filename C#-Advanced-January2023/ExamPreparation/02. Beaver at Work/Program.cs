using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> branches = new Queue<char>();
            int countOfpond = int.Parse(Console.ReadLine());
            char[,] pond = new char[countOfpond, countOfpond];

            for (int row = 0; row < countOfpond; row++)
            {
                char[] data = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < countOfpond; col++)
                {
                    pond[row, col] = data[col];
                }
            }

            int countOfBranches = 0;
            //intitalize the  breaver position
            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < countOfpond; row++)
            {
                for (int col = 0; col < countOfpond; col++)
                {
                    if (pond[row, col] == 'B')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                    else if (char.IsLower(pond[row, col]))
                    {
                        countOfBranches++;
                    }
                }
            }

            pond[currentRow, currentCol] = '-';

          
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }
                if (command == "up")
                {
                    if (IsSafe(pond, currentRow - 1, currentCol))
                    {
                        currentRow--;
                        if (char.IsLower(pond[currentRow, currentCol]))
                        {
                            //char is branch
                            branches.Enqueue(pond[currentRow, currentCol]);
                            pond[currentRow, currentCol] = '-';
                            countOfBranches--;
                        }
                        else 
                        {
                            pond[currentRow, currentCol] = '-';
                            if (currentRow == 0)
                            {
                                //we grab the oposite direction
                                currentRow = pond.GetLength(0) - 1;
                                if (Char.IsLower(pond[currentRow, currentCol]))
                                {
                                    branches.Enqueue(pond[currentRow, currentCol]);
                                    countOfBranches--;
                                }
                            }
                            else
                            {

                                currentRow = 0;
                                if (Char.IsLower(pond[currentRow, currentCol]))
                                {
                                    branches.Enqueue(pond[currentRow, currentCol]);
                                    countOfBranches--;
                                }

                            }


                        }
                    }
                    else
                    {
                        if (branches.Count > 0)
                        {
                            branches.Dequeue();
                        }
                    }
                }
                else if (command == "down")
                {
                    if (IsSafe(pond, currentRow + 1, currentCol))
                    {
                        currentRow++;
                        if (char.IsLower(pond[currentRow, currentCol]))
                        {
                            //char is branch
                            branches.Enqueue(pond[currentRow, currentCol]);
                            pond[currentRow, currentCol] = '-';
                            countOfBranches--;
                        }
                        else 
                        {
                            pond[currentRow, currentCol] = '-';
                            if ( currentRow == pond.GetLength(1)-1)
                            {
                                //we grab the oposite direction
                                currentRow = 0;
                                if (Char.IsLower(pond[currentRow, currentCol]))
                                {
                                    branches.Enqueue(pond[currentRow, currentCol]);
                                    countOfBranches--;
                                }
                            }
                            else
                            {

                                currentRow = pond.GetLength(0) - 1;
                                if (Char.IsLower(pond[currentRow, currentCol]))
                                {
                                    branches.Enqueue(pond[currentRow, currentCol]);
                                    countOfBranches--;
                                }
                            }

                        }
                    }
                    else
                    {
                        if (branches.Count > 0)
                        {
                            branches.Dequeue();
                        }
                    }

                }
                else if (command == "left")
                {
                    if (IsSafe(pond, currentRow, currentCol - 1))
                    {
                        currentCol--;
                        if (char.IsLower(pond[currentRow, currentCol]))
                        {
                            //char is branch
                            countOfBranches--;
                            branches.Enqueue(pond[currentRow, currentCol]);
                            pond[currentRow, currentCol] = '-';
                        }
                        else 
                        {
                            pond[currentRow, currentCol] = '-';
                            if (currentRow == 0)
                            {
                                //we grab the oposite direction
                                currentCol = pond.GetLength(0) - 1;
                                if (Char.IsLower(pond[currentRow, currentCol]))
                                {
                                    branches.Enqueue(pond[currentRow, currentCol]);
                                    countOfBranches--;
                                }
                            }
                            else
                            {

                                currentCol = 0;
                                if (Char.IsLower(pond[currentRow, currentCol]))
                                {
                                    branches.Enqueue(pond[currentRow, currentCol]);
                                    countOfBranches--;
                                }
                            }
                        }
                    }
                    else
                    {

                        if (branches.Count > 0)
                        {
                            branches.Dequeue();
                        }
                    }
                }
                else if (command == "right")
                {
                    if (IsSafe(pond, currentRow, currentCol + 1))
                    {
                        currentCol++;
                        if (char.IsLower(pond[currentRow, currentCol]))
                        {
                            //char is branch
                            countOfBranches--;
                            branches.Enqueue(pond[currentRow, currentCol]);
                            pond[currentRow, currentCol] = '-';
                        }
                        else 
                        {
                            pond[currentRow, currentCol] = '-';
                            if ( currentCol == pond.GetLength(1)-1)
                            {
                                //we grab the oposite direction
                                currentCol = 0;
                                if (Char.IsLower(pond[currentRow, currentCol]))
                                {
                                    branches.Enqueue(pond[currentRow, currentCol]);
                                    countOfBranches--;
                                }
                            }
                            else
                            {

                                currentCol = pond.GetLength(0) - 1;
                                if (Char.IsLower(pond[currentRow, currentCol]))
                                {
                                    branches.Enqueue(pond[currentRow, currentCol]);
                                    countOfBranches--;
                                }
                            }
                        }
                    }
                        else
                        {

                            if (branches.Count > 0)
                            {
                                branches.Dequeue();
                            }
                        }


                }
                command = Console.ReadLine();

                if (countOfBranches == 0)
                {
                    break;
                }
            }

            if (countOfBranches == 0)
            {
                List<char> result = new List<char>(branches);
                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", result)}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {countOfBranches} branches left.");
            }

            pond[currentRow, currentCol] = 'B';

            for (int row = 0; row < pond.GetLength(0); row++)
            {
                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    Console.Write((char)pond[row, col]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    
           private static bool IsSafe(char[,] pond, int currentRow, int currentCol)
            {
                if (currentRow >= 0 && currentRow < pond.GetLength(0) && currentCol >= 0 && currentCol < pond.GetLength(1))
                {
                    return true;
                }
                return false;
            }
    }
}