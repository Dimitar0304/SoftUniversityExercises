using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCordinatesTrue = false;
            //create a program that reads a string matrix 
            // at first line we recive his diamations in array
            //we recive till end command comand in this type
            // swap row1 col1 row2 col2
            //if we recive command without swap
            //less than 4 cordinates
            //more than 4 cordinates
            // and if they are not contain in this matrix
            //we print "Invalid input!" 
            int[] dimations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[dimations[0], dimations[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] data = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            string command = Console.ReadLine();
            while (command!="END")
            {
                string[] commandInfo = command.Split();
                string type = commandInfo[0];
                if (commandInfo.Length==5&&IsCordinatesTrue(command,matrix)==true&&type=="swap")
                {
                    
                    int SRow1 = int.Parse(commandInfo[1]);
                    int SCol1 = int.Parse(commandInfo[2]);
                    int SRow2 = int.Parse(commandInfo[3]);        
                    int SCol2 = int.Parse(commandInfo[4]);

                    string currentSwap1 = matrix[SRow1, SCol1];
                    string currentSwap2 = matrix[SRow2, SCol2];
                    matrix[SRow1, SCol1] = currentSwap2;
                    matrix[SRow2, SCol2] = currentSwap1;
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                       
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write($"{matrix[row,col]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine();
            }
        }

        public static bool IsCordinatesTrue(string command,string[,]matrix)
        {
            string[] commandInfo = command.Split();
            int SRow1 = int.Parse(commandInfo[1]);
            int SRow2 = int.Parse(commandInfo[3]);
            int SCol1 = int.Parse(commandInfo[2]);
            int SCol2 = int.Parse(commandInfo[4]);

            int countOfTrues = 0;
            if (SRow1>=0&&SRow1<matrix.GetLength(0))
            {
                countOfTrues++;
            }
            if (SRow2 >= 0 && SRow2 < matrix.GetLength(0))
            {
                countOfTrues++;
            }
            if (SCol1 >= 0 && SCol1 < matrix.GetLength(1))
            {
                countOfTrues++;
            }
            if (SCol2 >= 0 && SCol2 < matrix.GetLength(1))
            {
                countOfTrues++;
            }
            if (countOfTrues==4)
            {
                return true;
            }
            return false;
        }
    }
}
