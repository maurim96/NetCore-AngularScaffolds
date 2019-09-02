using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CRUD_Companies.UpdateCompanyUseCase
{
    public class UpdateCompanyUseCase : IUpdateCompanyUseCase
    {
        private readonly ICompaniesRepository _companiesRepository;
        public UpdateCompanyUseCase(ICompaniesRepository companiesRepository)
        {
            _companiesRepository = companiesRepository;
        }

        public async Task ExecuteAsync(Company company)
        {
            await _companiesRepository.UpdateCompany(company);
        }
    }
}
