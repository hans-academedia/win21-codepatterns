namespace _01_DIP.Interfaces
{
    internal interface IFileHandler
    {
        string FilePath { get; set; }

        string ReadFromFile();
        void WriteToFile(string content);
    }
}