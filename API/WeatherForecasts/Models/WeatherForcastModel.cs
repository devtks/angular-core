using TypeGen.Core.TypeAnnotations;

namespace angular_core.API.SampleData.Models
{
    [ExportTsInterface]
    public class WeatherForecastModel
    {
        public string DateFormatted { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }
}