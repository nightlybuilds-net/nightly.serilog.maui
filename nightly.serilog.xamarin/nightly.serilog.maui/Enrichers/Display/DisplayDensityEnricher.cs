using Serilog.Core;
using Serilog.Events;

namespace nightly.serilog.maui.Enrichers.Display
{
    public class DisplayDensityEnricher : ILogEventEnricher
    {
        private LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var displayInfo = DeviceDisplay.MainDisplayInfo;
            this._cachedProperty ??= propertyFactory.CreateProperty("DisplayDensity",displayInfo.Density);
            logEvent.AddPropertyIfAbsent(this._cachedProperty);
        }
    }
}