using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DIP.Devices
{
    internal interface IDevice
    {
        public string DeviceId { get; set; }
        public DeviceClient DeviceClient { get; set; }
        public string ConnectionString { get; set; }
        public string DeviceType { get; set; }

        void Connect();
        Task UpdateDeviceTypeAsync();
    }
}
