using Serilog.Core;
using Serilog.Events;

namespace nightly.serilog.maui.Enrichers.DeviceInfo
{
    public class DeviceTypeEnricher : ILogEventEnricher
    {
        private LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            this._cachedProperty ??= propertyFactory.CreateProperty("DeviceType", Microsoft.Maui.Devices.DeviceInfo.DeviceType);
            logEvent.AddPropertyIfAbsent(this._cachedProperty);
        }
    }
}