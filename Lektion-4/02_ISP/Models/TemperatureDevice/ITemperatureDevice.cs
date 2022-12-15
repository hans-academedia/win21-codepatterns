using _02_ISP.Interfaces;

namespace _02_ISP.Models.TemperatureDevice
{
    internal interface ITemperatureDevice : IDevice
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
    }
}
