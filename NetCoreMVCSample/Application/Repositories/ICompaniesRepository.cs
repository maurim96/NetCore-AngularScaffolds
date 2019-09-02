using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface ICompaniesRepository
    {
        Task<IList<Company>> GetAllCompanies();
        Task<Company> GetCompanyById(int idCompany);
        Task CreateCompany(Company company);
        Task DeleteCompanyById(int idCompany);
        Task UpdateCompany(Company company);
    }
}
