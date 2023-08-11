using Serilog.Core;
using Serilog.Events;

namespace nightly.serilog.maui.Enrichers.DeviceInfo
{
    public class DeviceIdiomEnricher : ILogEventEnricher
    {
        private LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            this._cachedProperty ??= propertyFactory.CreateProperty("DeviceIdiom", Microsoft.Maui.Devices.DeviceInfo.Idiom);
            logEvent.AddPropertyIfAbsent(this._cachedProperty);
        }
    }
}