using AutoMapper;
using Domain.Entities;
using Persistance.EFCore.SQLServer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.EFCore.SQLServer.Mapper
{
    public class EntityToDomainMapper : Profile
    {
        public EntityToDomainMapper()
        {
            CreateMap<Companies, Company>();
        }
    }
}
