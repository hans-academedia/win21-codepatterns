using _01_DRY.Handlers;

namespace _01_DRY.Interfaces.Handlers;

internal interface ILogger
{
    void LogInformation(string message, LoggerMessageTypes messageType = LoggerMessageTypes.Information);
}
