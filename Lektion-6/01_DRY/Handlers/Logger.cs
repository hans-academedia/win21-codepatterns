using System.Diagnostics;
using _01_DRY.Interfaces.Handlers;

namespace _01_DRY.Handlers;

internal enum LoggerMessageTypes
{
    Information,
    Error
}

internal class Logger : ILogger
{
    public void LogInformation(string message, LoggerMessageTypes messageType = LoggerMessageTypes.Information)
    {
        if (messageType == LoggerMessageTypes.Error)
            Console.Error.WriteLine(message);
        else
            Console.WriteLine(message);

        Debug.WriteLine(message);
    }
}
