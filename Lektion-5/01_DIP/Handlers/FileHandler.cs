using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_DIP.Interfaces;

namespace _01_DIP.Handlers
{
    internal class FileHandler : IFileHandler
    {
        public FileHandler()
        {
            FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\log.txt";
        }

        public string FilePath { get; set; }

        public string ReadFromFile()
        {
            try
            {
                using StreamReader sr = new StreamReader(FilePath);
                return sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to read file from {FilePath}");
                Debug.WriteLine(ex.Message);
                return string.Empty;
            }
        }

        public void WriteToFile(string content)
        {
            try
            {
                using StreamWriter sw = new StreamWriter(FilePath);
                sw.WriteLine(content);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to save content to {FilePath}");
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
