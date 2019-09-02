using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CRUD_Companies.DeleteCompanyByIdUseCase
{
    public interface IDeleteCompanyByIdUseCase
    {
        Task ExecuteAsync(int idCompany);
    }
}
