using Serilog.Core;
using Serilog.Events;

namespace nightly.serilog.maui.Enrichers.Version
{
    public class CurrentVersionBuildEnricher : ILogEventEnricher
    {
        private LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            this._cachedProperty ??= propertyFactory.CreateProperty("AppBuildVersion", VersionTracking.CurrentBuild);
            logEvent.AddPropertyIfAbsent(this._cachedProperty);
        }
    }
}