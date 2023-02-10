using Serilog.Core;
using Serilog.Events;

namespace nightly.serilog.maui.Enrichers.DeviceInfo
{
    public class DevicePlatformEnricher : ILogEventEnricher
    {
        private LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            this._cachedProperty ??= propertyFactory.CreateProperty("DevicePlatform", Microsoft.Maui.Devices.DeviceInfo.Platform);
            logEvent.AddPropertyIfAbsent(this._cachedProperty);
        }
    }
}