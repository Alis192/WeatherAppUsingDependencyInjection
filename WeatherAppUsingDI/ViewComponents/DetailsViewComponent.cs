using Microsoft.AspNetCore.Mvc;
using Models;

namespace WeatherAppUsingDI.ViewComponents
{
    public class DetailsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather city) //data is passed with city parameter
        {
            return View(city); //data with city parameter is transferred to the view in ~/View/Shared/Components/Details/Default.cshtml
        }
    }
}
