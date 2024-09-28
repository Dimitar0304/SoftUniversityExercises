using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //first we recive count of rows int
            //then we mapping the matrix after that we start to analyzing if row  one row below is with same lenght multiply * 2
            //else divide by 2
            // after that wwe recive commands until the end command
            // Add {row} {col} {value} or Subtract {row} {col} {value} check the cordinates with method
            //after end command print the matrix

            int rows = int.Parse(Console.ReadLine());
            int[][] jagedArr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagedArr[row] =  new int[numbers.Length];
                for (int col = 0; col < jagedArr[row].Length; col++)
                {
                    jagedArr[row][col] = numbers[col];
                }
            }

            for (int row = 0; row < rows-1; row++)
            {
                if (jagedArr[row].Length==jagedArr[row+1].Length)
                {
                    for (int col = 0; col < jagedArr[row].Length; col++)
                    {
                        jagedArr[row][col] *= 2;
                        jagedArr[row + 1][col] *= 2;
                    }

                }
                else
                {
                    for (int col = 0; col < jagedArr[row].Length; col++)
                    {
                        jagedArr[row][col] /= 2;
                    }
                    for (int col1 = 0; col1 < jagedArr[row+1].Length; col1++)
                    {
                        jagedArr[row+1][col1] /= 2;
                    }
                }
                
            }

            string comand = Console.ReadLine();
            while (comand!="End")
            {
                string[] commandInfo = comand.Split();
                string type = commandInfo[0];
                int row = int.Parse(commandInfo[1]);
                int col = int.Parse(commandInfo[2]);
                int value = int.Parse(commandInfo[3]);
                if (commandInfo.Length==4 && IsCordinatesTrue(commandInfo,jagedArr)==true)
                {
                    if (type == "Add")
                    {
                        jagedArr[row][col] += value;
                    }
                    if (type == "Subtract")
                    {
                        jagedArr[row][col] -= value;
                    }                 
                }
                
                comand = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
              
                for (int col = 0; col < jagedArr[row].Length; col++)
                {
                    Console.Write($"{jagedArr[row][col]} ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsCordinatesTrue(string[] commandInfo, int[][] jagedArr)
        {
            int trueCounter = 0;
            int row = int.Parse(commandInfo[1]);
            int col  = int.Parse(commandInfo[2]);
            if (row>=0&&row<jagedArr.Length)
            {
                trueCounter++;
            }
            else
            {
                return false;   
            }
            if (col>=0 &&col<jagedArr[row].Length)
            {
                trueCounter++;
            }
            else
            {
                return false;
            }
            if (trueCounter==2)
            {
                return true;
            }
            return false;
        }
    }
}
