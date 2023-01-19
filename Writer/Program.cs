using System.Net;
using Serilog;
using Serilog.Sinks.Network;

var ip = IPAddress.Parse("127.0.0.1");
var logger = new LoggerConfiguration()
    .WriteTo.TCPSink(ip, 1337)
    .CreateLogger();

logger.Information($"HELLO 4!");
logger.Information($"HELLO 5!");
logger.Information($"HELLO 3!");
await Task.Delay(2000);

