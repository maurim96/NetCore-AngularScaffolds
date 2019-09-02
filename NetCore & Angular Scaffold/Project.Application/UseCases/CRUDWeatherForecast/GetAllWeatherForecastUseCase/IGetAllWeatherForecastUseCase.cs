using Project.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.UseCases.CRUDWeatherForecast.GetAllWeatherForecastUseCase
{
    public interface IGetAllWeatherForecastUseCase
    {
        IEnumerable<WeatherForecast> Execute();
    }
}
