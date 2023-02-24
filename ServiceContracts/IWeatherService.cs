using Models;

namespace ServiceContracts
{
    public interface IWeatherService
    {
        List<CityWeather> GetWeatherDetails();  //Returns a list of CityWeather objects that contains weather details of cities
        
        CityWeather? GetWeatherByCityCode(string CityCode); //Returns an object of CityWeather based on the given city code
        

        //in general interface methods are public and abstract. So we don't need to define them explicitly
    }
}