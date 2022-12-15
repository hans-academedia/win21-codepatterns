using System.Diagnostics;

namespace _02_DRY.Helpers
{
    public interface ILogger
    {
        void LogInformation(string message);
    }

    public class Logger : ILogger
    {
        public void LogInformation(string message)
        {
            Console.WriteLine(message);
            Debug.WriteLine(message);
        }
    }
}
