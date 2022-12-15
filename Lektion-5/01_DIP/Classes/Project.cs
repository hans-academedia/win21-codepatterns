using _01_DIP.Handlers;
using _01_DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DIP.Classes
{
    internal class Project : IProject
    {
        private ILogger _logger;
        private IFileHandler _fileHandler;
        private IMessageHandler _messageHandler;

        public Project(ILogger logger, IFileHandler fileHandler, IMessageHandler messageHandler)
        {
            _logger = logger;
            _fileHandler = fileHandler;
            _messageHandler = messageHandler;
        }

        public Guid ProjectNumber { get; set; } = Guid.NewGuid();
        public string ProjectName { get; set; } = null!;
        public IPerson Owner { get; set; } = null!;
        public IPerson Consultant { get; set; } = null!;
        public double SpentHours { get; private set; }
        public bool IsCompleted { get; private set; }

        public void RegisterHours(double hours)
        {
            SpentHours += hours;
            var message = $"{Consultant.DisplayName} spent {hours} {hours switch { > 1 => "hours", _ => "hour" }} on project {ProjectNumber}. Total project hours: {SpentHours}.";

            _logger.Log(message);
            WriteLogFile(message);
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
            var message = $"{ProjectNumber} - {ProjectName} is completed.";

            _logger.Log(message);
            WriteLogFile(message);

            _messageHandler.Send(Owner, $"{ProjectName} is now completed.");
            _logger.Log($"Message sent to product owner {Owner.DisplayName}.");
            WriteLogFile($"Message sent to product owner {Owner.DisplayName}.\n");
        }

        private void WriteLogFile(string message)
        {
            var content = _fileHandler.ReadFromFile();
            _fileHandler.WriteToFile($"{content}{message}");
        }
    }
}