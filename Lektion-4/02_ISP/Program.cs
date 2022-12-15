using _02_ISP.Handlers;
using _02_ISP.Models.TemperatureDevice;
using _02_ISP.Models.WaterPumpDevice;

using var iotHubHandler = new IotHubHandler("HostName=win21-iothub.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=g64aYZwWzwm7EfB3U9iNsBNYVcpg/QprT6xhQM8BfFM=");

ITemperatureDevice temperatureDevice = new TemperatureDevice { DeviceId = Guid.NewGuid().ToString() };
temperatureDevice.ConnectionString = await iotHubHandler.RegisterDeviceAsync(temperatureDevice.DeviceId);
temperatureDevice.Connect();
await temperatureDevice.UpdateDeviceTypeAsync();

Console.WriteLine();

IWaterPumpDevice waterPumpDevice = new WaterPumpDevice { DeviceId = Guid.NewGuid().ToString(), MinWaterLevel = 0.0f, MaxWaterLevel = 5.0f };
waterPumpDevice.ConnectionString = await iotHubHandler.RegisterDeviceAsync(waterPumpDevice.DeviceId);
waterPumpDevice.Connect();
await waterPumpDevice.UpdateDeviceTypeAsync();

Console.ReadKey();
