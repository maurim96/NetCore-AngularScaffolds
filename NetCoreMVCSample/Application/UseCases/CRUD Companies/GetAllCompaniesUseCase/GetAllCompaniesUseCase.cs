using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CRUD_Companies.GetAllCompaniesUseCase
{
    public class GetAllCompaniesUseCase : IGetAllCompaniesUseCase
    {
        private readonly ICompaniesRepository _companiesRepository;
        public GetAllCompaniesUseCase(ICompaniesRepository companiesRepository)
        {
            _companiesRepository = companiesRepository;
        }

        public async Task<IList<Company>> ExecuteAsync()
        {
            return await _companiesRepository.GetAllCompanies();
        }
    }
}
