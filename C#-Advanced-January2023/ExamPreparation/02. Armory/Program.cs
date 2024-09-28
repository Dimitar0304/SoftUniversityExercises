using System;
using System.Linq;

namespace _02._Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int goldCoins = 0;
            char[,] armory = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string data = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    armory[row, col] = data[col];
                }
            }

            int oficerRow = 0;
            int oficerCol = 0;
            //initialize the A officer
            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    if (armory[row, col] == 'A')
                    {
                        oficerRow = row;
                        oficerCol = col;
                    }
                }
            }

            armory[oficerRow, oficerCol] = '-';

            while (true)
            {
                if (goldCoins >= 65)
                {
                    break;
                }
                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (IsSafe(n, oficerRow - 1, oficerCol) == true)
                    {
                        oficerRow--;
                        if (char.IsDigit(armory[oficerRow,oficerCol]))
                        {
                            goldCoins += Convert.ToInt32(new string(armory[oficerRow,oficerCol], 1));
                            armory[oficerRow, oficerCol] = '-';
                        }
                        else if(armory[oficerRow,oficerCol]=='M')
                        {
                            armory[oficerRow, oficerCol] = '-';
                            oficerRow = GetMirrorCordinateForRow(armory);
                            oficerCol = GetMirrorCordinateForCol(armory);
                            armory[oficerRow, oficerCol] = '-';
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (IsSafe(n, oficerRow + 1, oficerCol) == true)
                    {
                        oficerRow++;
                        if (char.IsDigit(armory[oficerRow, oficerCol]))
                        {
                            goldCoins += Convert.ToInt32(new string(armory[oficerRow, oficerCol], 1));
                            armory[oficerRow, oficerCol] = '-';
                        }
                        else if (armory[oficerRow, oficerCol] == 'M')
                        {
                            armory[oficerRow, oficerCol] = '-';
                            oficerRow = GetMirrorCordinateForRow(armory);
                            oficerCol = GetMirrorCordinateForCol(armory);
                            armory[oficerRow, oficerCol] = '-';
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (IsSafe(n, oficerRow, oficerCol - 1) == true)
                    {
                        oficerCol--;
                        if (char.IsDigit(armory[oficerRow, oficerCol]))
                        {
                            goldCoins += Convert.ToInt32(new string(armory[oficerRow, oficerCol], 1));
                            armory[oficerRow, oficerCol] = '-';
                        }
                        else if (armory[oficerRow, oficerCol] == 'M')
                        {
                            armory[oficerRow, oficerCol] = '-';
                            oficerRow = GetMirrorCordinateForRow(armory);
                            oficerCol = GetMirrorCordinateForCol(armory);
                            armory[oficerRow, oficerCol] = '-';
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (IsSafe(n, oficerRow, oficerCol + 1) == true)
                    {
                        oficerCol++;
                        if (char.IsDigit(armory[oficerRow, oficerCol]))
                        {
                            goldCoins += Convert.ToInt32(new string(armory[oficerRow, oficerCol], 1));
                            armory[oficerRow, oficerCol] = '-';
                        }
                        else if (armory[oficerRow, oficerCol] == 'M')
                        {
                            armory[oficerRow, oficerCol] = '-';
                            oficerRow = GetMirrorCordinateForRow(armory);
                            oficerCol = GetMirrorCordinateForCol(armory);
                            armory[oficerRow, oficerCol] = '-';
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }

            if (goldCoins>=65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
                armory[oficerRow, oficerCol] = 'A';
            }
            else
            {
                Console.WriteLine("I do not need more swords!");
            armory[oficerRow, oficerCol] = '-';
            }

            Console.WriteLine($"The king paid {goldCoins} gold coins.");


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{armory[row,col]}");
                }
                Console.WriteLine();
            }


            bool IsSafe(int n, int currentRow, int currentCol)
            {
                if (currentRow >= 0 && currentRow < n && currentCol >= 0 && currentCol < n)
                {
                    return true;
                }
                return false;
            }
            int GetMirrorCordinateForRow(char[,] armory)
            {
                for (int row = 0; row < armory.GetLength(0); row++)
                {

                    for (int col = 0; col < armory.GetLength(1); col++)
                    {
                        if (armory[row, col] == 'M')
                        {
                            return row;
                        }
                    }

                }
                return default;
            }
            int GetMirrorCordinateForCol(char[,] armory)
            {
                for (int row = 0; row < armory.GetLength(0); row++)
                {

                    for (int col = 0; col < armory.GetLength(1); col++)
                    {
                        if (armory[row, col] == 'M')
                        {
                            return col;
                        }
                    }
                }
                return default;
            }
        }

    }
}
