using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DIP.Devices.WaterPumpSensor
{
    internal interface IWaterPumpSensor : IDevice
    {
        public float CurrentWaterLevel { get; set; }
        public float MaximumWaterLevel { get; set; }
        public float MinimumWatherLevel { get; set; }
    }
}
