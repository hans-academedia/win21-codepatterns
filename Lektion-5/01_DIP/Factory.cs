using _01_DIP.Classes;
using _01_DIP.Handlers;
using _01_DIP.Interfaces;

namespace _01_DIP
{
    internal static class Factory
    {
        public static IProjectOwner ProjectOwner()
        {
            return new ProjectOwner();
        }
        public static IProjectOwner ProjectOwner(string firstName, string lastName, string email, string phoneNumber)
        {
            return new ProjectOwner()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber
            };
        }

        public static IConsultant Consultant()
        {
            return new Consultant();
        }
        public static IConsultant Consultant(string firstName, string lastName, string email, string phoneNumber)
        {
            return new Consultant()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber
            };
        }

        public static IProject Project()
        {
            return new Project(Logger(), FileHandler(), MessageHandler());
        }
        public static IProject Project(string projectName, IPerson projectOwner, IPerson consultant)
        {
            return new Project(Logger(), FileHandler(), MessageHandler())
            {
                ProjectName = projectName,
                Owner = projectOwner,
                Consultant = consultant
            };
        }


        public static ILogger Logger()
        {
            return new Logger();
        }

        public static IFileHandler FileHandler()
        {
            return new FileHandler();
        }

        public static IMessageHandler MessageHandler()
        {
            return new EmailHandler();
        }
    }
}
