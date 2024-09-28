namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            string[] fileNames = Directory.GetFiles(inputPath);
            for (int i = 0; i < fileNames.Length; i++)
            {
                File.Copy(fileNames[i], outputPath);
            }
        }
    }
}

