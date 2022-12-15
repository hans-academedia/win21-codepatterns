using _02_ISP.Interfaces;

namespace _02_ISP.Models.WaterPumpDevice
{
    internal interface IWaterPumpDevice : IDevice
    {
        public float CurrentWaterLevel { get; set; }
        public float MinWaterLevel { get; set; }
        public float MaxWaterLevel { get; set; }
    }
}
