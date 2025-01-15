namespace BlazorApp1.Models
{
    public class GeoNamesResponse
    {
        public Geoname[] Geonames { get; set; } = Array.Empty<Geoname>();
    }

    public class Geoname
    {
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        public string? Name { get; set; } // Название города
        public int? Population { get; set; } // Численность населения
        public string? AdminCode1 { get; set; } // Код административного деления
        public string? AdminName1 { get; set; } // Название административного деления
    }
}