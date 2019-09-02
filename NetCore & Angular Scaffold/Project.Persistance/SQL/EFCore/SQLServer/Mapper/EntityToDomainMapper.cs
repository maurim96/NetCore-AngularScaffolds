using AutoMapper;
using Project.Persistance.SQL.EFCore.SQLServer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Persistance.SQL.EFCore.SQLServer.Mapper
{
    public class EntityToDomainMapper : Profile
    {
        public EntityToDomainMapper()
        {
            CreateMap<WheaterForecast, Domain.WeatherForecast>()
                    .ForMember(x => x.Summary, opt => opt.MapFrom(x => x.Summary.Summary))
                    .ForMember(x => x.DateFormatted, opt => opt.MapFrom(x => x.Date));
        }
    }
}
