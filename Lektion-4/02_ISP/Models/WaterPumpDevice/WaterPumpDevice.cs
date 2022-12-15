using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Shared;

namespace _02_ISP.Models.WaterPumpDevice
{
    internal class WaterPumpDevice : IWaterPumpDevice
    {
        public float CurrentWaterLevel { get; set; }
        public float MinWaterLevel { get; set; }
        public float MaxWaterLevel { get; set; }
        public string DeviceId { get; set; }
        public DeviceClient DeviceClient { get; set; }
        public string ConnectionString { get; set; }
        public string DeviceType { get; set; } = nameof(WaterPumpDevice);

        public void Connect()
        {
            if (DeviceClient != null)
                Console.WriteLine($"Connecting device {DeviceId} to Azure IoT Hub...");
            else
            {
                Console.WriteLine($"Connecting device {DeviceId} to Azure IoT Hub...");
                DeviceClient = DeviceClient.CreateFromConnectionString(ConnectionString);
            }
        }

        public async Task UpdateDeviceTypeAsync()
        {
            Console.WriteLine($"Updating the device type for device {DeviceId} to {DeviceType}...");

            var collection = new TwinCollection();
            collection["deviceType"] = DeviceType;
            await DeviceClient.UpdateReportedPropertiesAsync(collection);
        }
    }
}
