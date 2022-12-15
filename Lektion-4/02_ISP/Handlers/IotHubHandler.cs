using Microsoft.Azure.Devices;

namespace _02_ISP.Handlers
{
    internal class IotHubHandler : IIotHubHandler
    {
        private readonly RegistryManager registryManager;
        public IotHubHandler(string connectionString)
        {
            registryManager = RegistryManager.CreateFromConnectionString(connectionString);
        }

        public async Task<string> RegisterDeviceAsync(string deviceId)
        {
            Console.WriteLine($"Registrering device {deviceId} in Azure IoT Hub...");

            var device = await registryManager.AddDeviceAsync(new Device(deviceId));
            if (device != null)
                return $"HostName=win21-iothub.azure-devices.net;DeviceId={device.Id};SharedAccessKey={device.Authentication.SymmetricKey.PrimaryKey}";
            
            return null;
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
