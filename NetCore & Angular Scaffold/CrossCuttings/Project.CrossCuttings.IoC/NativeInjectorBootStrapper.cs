using Microsoft.Extensions.DependencyInjection;
using Project.Application.Repositories;
using Project.Application.UseCases.CRUDWeatherForecast.GetAllWeatherForecastUseCase;
using Project.CrossCuttings.ErrorHandler.Interfaces;
using Project.Persistance.SQL.EFCore.SQLServer.Repository;
using System;

namespace Project.CrossCuttings.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Use Cases
            services.AddScoped<IGetAllWeatherForecastUseCase, GetAllWeatherForecastUseCase>();

            //Repositories
            services.AddTransient<IWeatherForecastRepository, WeatherForecastRepository>();

            //CrossCuttings
                //ErrorHandler
                services.AddScoped<IErrorHandler, ErrorHandler.Implementations.ErrorHandler>();
        }
    }
}
