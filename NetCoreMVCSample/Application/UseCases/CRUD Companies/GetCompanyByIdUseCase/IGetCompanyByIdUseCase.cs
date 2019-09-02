using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CRUD_Companies.GetCompanyByIdUseCase
{
    public interface IGetCompanyByIdUseCase
    {
        Task<Company> ExecuteAsync(int idCompany);
    }
}
