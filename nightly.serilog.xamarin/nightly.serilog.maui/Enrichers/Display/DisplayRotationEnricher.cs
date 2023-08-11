using Serilog.Core;
using Serilog.Events;

namespace nightly.serilog.maui.Enrichers.Display
{
    public class DisplayRotationEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var displayInfo = DeviceDisplay.MainDisplayInfo;
            var orientationProperty = propertyFactory.CreateProperty("DisplayRotation",displayInfo.Rotation);
            logEvent.AddPropertyIfAbsent(orientationProperty);
        }
    }
}