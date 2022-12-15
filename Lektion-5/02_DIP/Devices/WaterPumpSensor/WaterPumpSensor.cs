using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DIP.Devices.WaterPumpSensor
{
    internal class WaterPumpSensor : IWaterPumpSensor
    {
        private TwinCollection _twinCollection;

        public WaterPumpSensor(TwinCollection twinCollection)
        {
            _twinCollection = twinCollection;
        }

        public string DeviceId { get; set; } = null!;
        public DeviceClient DeviceClient { get; set; } = null!;
        public string ConnectionString { get; set; } = null!;
        public string DeviceType { get; set; } = nameof(WaterPumpSensor).ToLower();
        public float CurrentWaterLevel { get; set; }
        public float MaximumWaterLevel { get; set; }
        public float MinimumWatherLevel { get; set; }

        public void Connect()
        {
            Console.WriteLine($"Connecting {DeviceId} to Azure IoT Hub...");
            DeviceClient ??= DeviceClient.CreateFromConnectionString(ConnectionString);
        }

        public async Task UpdateDeviceTypeAsync()
        {
            Console.WriteLine($"Updating device type for {DeviceId} to be {DeviceType}...");

            _twinCollection["deviceType"] = DeviceType;
            await DeviceClient.UpdateReportedPropertiesAsync(_twinCollection);
        }
    }
}
