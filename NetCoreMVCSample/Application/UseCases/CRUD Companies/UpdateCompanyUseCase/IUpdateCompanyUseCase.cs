using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CRUD_Companies.UpdateCompanyUseCase
{
    public interface IUpdateCompanyUseCase
    {
        Task ExecuteAsync(Company company);
    }
}
