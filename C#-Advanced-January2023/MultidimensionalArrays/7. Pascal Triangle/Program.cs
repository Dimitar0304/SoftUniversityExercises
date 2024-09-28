using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] Pascal = new long[rows][];
            Pascal[0] = new long[1]{1};
            for (int row = 1; row < rows; row++)
            {
                Pascal[row] = new long[row+1];
                for (int col = 0; col < Pascal[row].Length; col++)
                {
                    if (Pascal[row-1].Length>col)
                    {
                        Pascal[row][col] += Pascal[row - 1][col];
                    }
                    if (col>0)
                    {
                        Pascal[row][col] += Pascal[row - 1][col - 1];
                    }
                }
            }
           

            //for (int row = 1; row < rows; row++)
            //{
            //    int cols = row + 1;
               
            //    for (int col = 0; col < cols; col++)
            //    {
            //        if (col>0||col<cols)
            //        {
            //            long UpperNumber = Pascal[row - 1][col];
            //            long LeftNumber = Pascal[row - 1][col - 1];
            //            Pascal[row][col] =UpperNumber + LeftNumber;
            //        }
            //        else
            //        {
            //            Pascal[row][col] = 1;
            //        }
                   
            //    }
            //}
            //for loop for print
            foreach (var row in Pascal)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
