using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project.Application.Repositories;
using Project.Domain;
using Project.Persistance.SQL.EFCore.SQLServer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Persistance.SQL.EFCore.SQLServer.Repository
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private readonly InitialDBContext _ctx;
        private readonly IMapper _mapper;
        public WeatherForecastRepository(InitialDBContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        public IEnumerable<WeatherForecast> GetAll()
        {
            var weatherForecast = _ctx.WheaterForecast.Include(x => x.Summary).ToList();
            if(weatherForecast.Count == 0)
            {
                SeedDatabase();
            }

            return _mapper.Map<List<WheaterForecast>, List<Domain.WeatherForecast>>(weatherForecast);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        private void SeedDatabase()
        {
            //Only for demo purposes
        }
    }
}
