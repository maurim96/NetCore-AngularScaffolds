using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CRUD_Companies.GetCompanyByIdUseCase
{
    public class GetCompanyByIdUseCase : IGetCompanyByIdUseCase
    {
        private readonly ICompaniesRepository _companiesRepository;
        public GetCompanyByIdUseCase(ICompaniesRepository companiesRepository)
        {
            _companiesRepository = companiesRepository;
        }

        public async Task<Company> ExecuteAsync(int idCompany)
        {
            return await _companiesRepository.GetCompanyById(idCompany);
        }
    }
}
