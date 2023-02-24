using ServiceContracts;
using Models;

namespace Services
{
    public class CitiesService : IWeatherService
    {
        List<CityWeather> cities = new List<CityWeather>()
        {
            new CityWeather() {CityUniqueCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"),  TemperatureFahrenheit = 33},
            new CityWeather() {CityUniqueCode = "NYC", CityName = "New York", DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60},
            new CityWeather() {CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
        };

        public List<CityWeather> GetWeatherDetails()
        {
            return cities;
        }

        public CityWeather? GetWeatherByCityCode(string CityCode)
        {
            return cities.Where(temp => temp.CityUniqueCode == CityCode).FirstOrDefault();
        }

    }
}