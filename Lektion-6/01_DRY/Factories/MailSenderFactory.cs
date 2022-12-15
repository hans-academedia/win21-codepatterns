using _01_DRY.Helpers;
using _01_DRY.Interfaces.Handlers;
using _01_DRY.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DRY.Factories
{
    internal static class MailSenderFactory
    {
        public static MailSender Create(IProject project, IMailer mailer, ILogger logger)
        {
            return new MailSender(project, mailer, logger);
        }
    }
}
