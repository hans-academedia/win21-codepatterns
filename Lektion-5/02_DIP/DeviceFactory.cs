using _02_DIP.Devices.TemperatureSensor;
using _02_DIP.Devices.WaterPumpSensor;
using _02_DIP.Handlers.IotHub;
using Microsoft.Azure.Devices.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DIP
{
    internal static class DeviceFactory
    {
        public static ITemperatureSensor TemperaturSensor(string deviceId)
        {
            return new TemperatureSensor(new TwinCollection()) { DeviceId = deviceId };
        }

        public static IWaterPumpSensor WaterPumpSensor(string deviceId)
        {
            return new WaterPumpSensor(new TwinCollection()) { DeviceId = deviceId };
        }
    }
}
