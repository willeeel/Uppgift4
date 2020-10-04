using Microsoft.Azure.Devices.Client;
using System;
using Xunit;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class SetTelemetryIntervalTests
    {
        private DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("", TransportType.Mqtt);

    }
}