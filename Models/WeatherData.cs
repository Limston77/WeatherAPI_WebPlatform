namespace BlazorApp1.Models
{
    public class WeatherData
    {
        public Location? Location { get; set; }
        public CurrentWeather? Current { get; set; }
    }

    public class Location
    {
        public string? Name { get; set; }
        public string? Localtime { get; set; }
        public string? Region { get; set; }
        public string? Country { get; set; }
    }

    public class CurrentWeather
    {
        public double? Temp_C { get; set; }
        public WeatherCondition? Condition { get; set; }
        public double? Wind_Kph { get; set; }
    }

    public class WeatherCondition
    {
        public string? Text { get; set; }
    }
}
