using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CRUD_Companies.GetAllCompaniesUseCase
{
    public interface IGetAllCompaniesUseCase
    {
        Task<IList<Company>> ExecuteAsync();
    }
}
