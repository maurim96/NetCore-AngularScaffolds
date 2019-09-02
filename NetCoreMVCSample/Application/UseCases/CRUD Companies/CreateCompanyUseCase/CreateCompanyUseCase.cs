using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CRUD_Companies.CreateCompanyUseCase
{
    public class CreateCompanyUseCase : ICreateCompanyUseCase
    {
        private readonly ICompaniesRepository _companiesRepository;
        public CreateCompanyUseCase(ICompaniesRepository companiesRepository)
        {
            _companiesRepository = companiesRepository;
        }

        public async Task ExecuteAsync(Company company)
        {
            await _companiesRepository.CreateCompany(company);
        }
    }
}
