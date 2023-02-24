using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;
using Models;

namespace WeatherAppUsingDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService; // we create a reference to IWeatherService. It means that it can refer to any object inherited from IWeatherSerice

        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService; //we create constructor and execute Service code and Hardcoded data is loaded to weatherService parameter
        }



        [Route("/")]
        [Route("/weather")]
        public IActionResult Index()
        {
            List<CityWeather> cities = _weatherService.GetWeatherDetails(); //we return cities from loaded data using Dependency Injection
            return View(cities); // data is passed to Index view and displayed there
        }


        [Route("/weather/{cityCode}")]
        public IActionResult Details(string? cityCode) //cityCode is fetched from Index view by clicking specific link.
        {
            CityWeather city = _weatherService.GetWeatherByCityCode(cityCode); //Service function to match the citycode with data 
            return View(city); //data is passed to Details view
        }
    }
}
