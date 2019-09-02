using Application.Repositories;
using Application.UseCases.CRUD_Companies.CreateCompanyUseCase;
using Application.UseCases.CRUD_Companies.DeleteCompanyByIdUseCase;
using Application.UseCases.CRUD_Companies.GetAllCompaniesUseCase;
using Application.UseCases.CRUD_Companies.GetCompanyByIdUseCase;
using Application.UseCases.CRUD_Companies.UpdateCompanyUseCase;
using Microsoft.Extensions.DependencyInjection;
using Persistance.EFCore.SQLServer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICreateCompanyUseCase, CreateCompanyUseCase>();
            services.AddScoped<IUpdateCompanyUseCase, UpdateCompanyUseCase>();
            services.AddScoped<IDeleteCompanyByIdUseCase, DeleteCompanyByIdUseCase>();
            services.AddScoped<IGetAllCompaniesUseCase, GetAllCompaniesUseCase>();
            services.AddScoped<IGetCompanyByIdUseCase, GetCompanyByIdUseCase>();

            services.AddTransient<ICompaniesRepository, CompaniesRepository>();
        }
    }
}
