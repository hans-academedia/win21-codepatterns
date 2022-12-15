namespace _02_ISP.Handlers
{
    internal interface IIotHubHandler : IDisposable
    {
        Task<string> RegisterDeviceAsync(string deviceId);
    }
}
