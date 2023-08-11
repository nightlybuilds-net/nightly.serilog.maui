using Serilog.Core;
using Serilog.Events;

namespace nightly.serilog.maui.Enrichers.DeviceInfo
{
    public class DeviceOsVersionEnricher : ILogEventEnricher
    {
        private LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            this._cachedProperty ??= propertyFactory.CreateProperty("DeviceOsVersion", Microsoft.Maui.Devices.DeviceInfo.VersionString);
            logEvent.AddPropertyIfAbsent(this._cachedProperty);
        }
    }
}