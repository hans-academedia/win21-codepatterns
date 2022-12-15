using Microsoft.Azure.Devices.Client;

namespace _02_ISP.Interfaces
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
