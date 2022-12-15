using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DIP.Devices.TemperatureSensor
{
    internal interface ITemperatureSensor : IDevice
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
    }
}
