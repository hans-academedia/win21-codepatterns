using Microsoft.Azure.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DIP.Handlers.IotHub
{
    internal class RegistryHandler : IRegistryHandler
    {
        private readonly RegistryManager registryManager;

        public RegistryHandler(string connectionString)
        {
            registryManager = RegistryManager.CreateFromConnectionString(connectionString);
        }

        public async Task<string> RegisterAsync(string deviceId)
        {
            Console.WriteLine($"Registrering {deviceId} in Azure IoT Hub...");

            var device = await registryManager.AddDeviceAsync(new Device(deviceId));
            if (device != null)
                return $"HostName=win21-iothub.azure-devices.net;DeviceId={device.Id};SharedAccessKey={device.Authentication.SymmetricKey.PrimaryKey}";

            return string.Empty;
        }

    }
}
