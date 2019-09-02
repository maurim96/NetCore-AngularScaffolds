using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.UseCases.CRUDWeatherForecast.GetAllWeatherForecastUseCase;
using Project.Web.Filters;

namespace Project.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(WebApiExceptionFilterAttribute))]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IGetAllWeatherForecastUseCase _getAllWeatherForecastUseCase;
        public WeatherForecastController(IGetAllWeatherForecastUseCase getAllWeatherForecastUseCase)
        {
            _getAllWeatherForecastUseCase = getAllWeatherForecastUseCase;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_getAllWeatherForecastUseCase.Execute());
        }
    }
}