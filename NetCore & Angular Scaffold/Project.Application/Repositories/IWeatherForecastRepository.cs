using Project.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.Repositories
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> GetAll();
        void SaveChanges();
    }
}
