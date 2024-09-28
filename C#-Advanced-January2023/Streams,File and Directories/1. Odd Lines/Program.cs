using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here…
            var reader = new StreamReader("../../../input.txt");
            StreamWriter writer = new StreamWriter(outputFilePath);
            int counter = 0;
            using (reader)
            {
                string currentLine = reader.ReadLine();
                using (writer = new StreamWriter("../../../output.txt"))

                {
                    while (currentLine!=null)
                    {
                        if (counter%2==1)
                        {
                            writer.WriteLine(currentLine);
                            
                        }
                        counter++;
                        currentLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}
