using System;
using System.Collections.Generic;
using System.Text;
using Project.Application.Repositories;
using Project.Domain;

namespace Project.Application.UseCases.CRUDWeatherForecast.GetAllWeatherForecastUseCase
{
    
    public class GetAllWeatherForecastUseCase : IGetAllWeatherForecastUseCase
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;
        public GetAllWeatherForecastUseCase(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }
        public IEnumerable<WeatherForecast> Execute()
        {
            return _weatherForecastRepository.GetAll();
        }
    }
}
