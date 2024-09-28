namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extentionsFiles = new SortedDictionary<string, List<FileInfo>>();
           
            string[] fileNames = Directory.GetFiles(inputFolderPath);
            for (int i = 0; i < fileNames.Length; i++)
            {
                FileInfo fileInfo = new FileInfo(fileNames[i]);
                if (!extentionsFiles.ContainsKey(fileInfo.Extension))
                {
                    extentionsFiles.Add(fileInfo.Extension, new List<FileInfo>());
                }
                extentionsFiles[fileInfo.Extension].Add(fileInfo);
            }
            StringBuilder sb = new StringBuilder();

            foreach (var extention in extentionsFiles.OrderByDescending(e => e.Value.Count))
            {
                sb.AppendLine(extention.Key);

                foreach (var file in extention.Value.OrderBy(ef => ef.Length))
                {
                    sb.AppendLine($"--{file.FullName} - {(double)file.Length / 1024:F3}");
                }
            }
            
            return sb.ToString();

        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(desktopPath, textContent);
           


        }
    }
}
