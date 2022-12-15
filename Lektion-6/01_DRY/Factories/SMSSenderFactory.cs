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
    internal static class SMSSenderFactory
    {
        public static SMSSender Create(IProject project, ISMS sms, ILogger logger)
        {
            return new SMSSender(project, sms, logger);
        }
    }
}
