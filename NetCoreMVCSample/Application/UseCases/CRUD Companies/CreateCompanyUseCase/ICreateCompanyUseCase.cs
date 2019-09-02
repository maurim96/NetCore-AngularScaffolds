using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CRUD_Companies.CreateCompanyUseCase
{
    public interface ICreateCompanyUseCase
    {
        Task ExecuteAsync(Company company);
    }
}
