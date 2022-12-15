using _02_DIP.Handlers.IotHub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DIP
{
    internal class IotHubFactory
    {
        public static IRegistryHandler RegistryHandler(string connectionString)
        {
            return new RegistryHandler(connectionString);
        }

    }
}
