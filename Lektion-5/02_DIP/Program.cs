using _02_DIP;
using _02_DIP.Devices.TemperatureSensor;
using _02_DIP.Devices.WaterPumpSensor;
using _02_DIP.Handlers.IotHub;


IRegistryHandler registryHandler = IotHubFactory.RegistryHandler("HostName=win21-iothub.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=g64aYZwWzwm7EfB3U9iNsBNYVcpg/QprT6xhQM8BfFM=");

ITemperatureSensor temperatureSensor = DeviceFactory.TemperaturSensor(Guid.NewGuid().ToString());
temperatureSensor.ConnectionString = await registryHandler.RegisterAsync(temperatureSensor.DeviceId);
temperatureSensor.Connect();
await temperatureSensor.UpdateDeviceTypeAsync();

Console.WriteLine();

IWaterPumpSensor waterPumpSensor = DeviceFactory.WaterPumpSensor(Guid.NewGuid().ToString());
waterPumpSensor.ConnectionString = await registryHandler.RegisterAsync(waterPumpSensor.DeviceId);
waterPumpSensor.Connect();
await waterPumpSensor.UpdateDeviceTypeAsync();