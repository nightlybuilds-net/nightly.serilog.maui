using nightly.serilog.maui.Sinks;
using Serilog;
using Serilog.Configuration;

namespace nightly.serilog.maui
{
    public static class SinkExtensions
    {
        public static LoggerConfiguration DebugConsole(
            this LoggerSinkConfiguration loggerConfiguration, bool enabled = true,
            IFormatProvider formatProvider = null)
        {
            return loggerConfiguration.Sink(new DebugConsoleSink(formatProvider, enabled));
        }
    }
}