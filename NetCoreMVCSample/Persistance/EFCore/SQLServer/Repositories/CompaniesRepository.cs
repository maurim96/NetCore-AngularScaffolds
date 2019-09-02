using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.EFCore.SQLServer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.EFCore.SQLServer.Repositories
{
    public class CompaniesRepository : ICompaniesRepository
    {
        private readonly IMapper _mapper;
        private readonly NetCoreMVCSampleDBContext _ctx;
        public CompaniesRepository(IMapper mapper, NetCoreMVCSampleDBContext netCoreMVCSampleDBContext)
        {
            _ctx = netCoreMVCSampleDBContext;
            _mapper = mapper;
        }
        public async Task CreateCompany(Company company)
        {
            var companyDB = _mapper.Map<Company, Companies>(company);
            _ = await _ctx.Companies.AddAsync(companyDB);
            _ = await _ctx.SaveChangesAsync();
        }

        public async Task DeleteCompanyById(int idCompany)
        {
            var companyDB = await _ctx.Companies.FindAsync(idCompany);
            _ctx.Companies.Remove(companyDB);
            _ = await _ctx.SaveChangesAsync();
        }

        public async Task<IList<Company>> GetAllCompanies()
        {
            var companiesDB = await _ctx.Companies.ToListAsync();
            return _mapper.Map<IList<Companies>, IList<Company>>(companiesDB);
        }

        public async Task<Company> GetCompanyById(int idCompany)
        {
            var companyDB = await _ctx.Companies.FindAsync(idCompany);
            return _mapper.Map<Companies, Company>(companyDB);
        }

        public async Task UpdateCompany(Company company)
        {
            _ctx.Companies.Update(_mapper.Map<Company, Companies>(company));
            _ = await _ctx.SaveChangesAsync();

        }
    }
}
