using Application.Repositories;
using Application.UseCases.CRUD_Companies.DeleteCompanyByIdUseCase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CRUD_Companies.DeleteCompanyByIdUseCase
{
    public class DeleteCompanyByIdUseCase : IDeleteCompanyByIdUseCase
    {
        private readonly ICompaniesRepository _companiesRepository;
        public DeleteCompanyByIdUseCase(ICompaniesRepository companiesRepository)
        {
            _companiesRepository = companiesRepository;
        }

        public async Task ExecuteAsync(int idCompany)
        {
            await _companiesRepository.DeleteCompanyById(idCompany);
        }
    }
}
