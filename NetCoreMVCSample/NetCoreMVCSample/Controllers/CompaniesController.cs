using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.UseCases.CRUD_Companies.CreateCompanyUseCase;
using Application.UseCases.CRUD_Companies.DeleteCompanyByIdUseCase;
using Application.UseCases.CRUD_Companies.GetAllCompaniesUseCase;
using Application.UseCases.CRUD_Companies.GetCompanyByIdUseCase;
using Application.UseCases.CRUD_Companies.UpdateCompanyUseCase;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCSample.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly IGetAllCompaniesUseCase _getAllCompaniesUseCase;
        private readonly IGetCompanyByIdUseCase _getCompanyByIdUseCase;
        private readonly ICreateCompanyUseCase _createCompanyUseCase;
        private readonly IUpdateCompanyUseCase _updateCompanyUseCase;
        private readonly IDeleteCompanyByIdUseCase _deleteCompanyByIdUseCase;
        public CompaniesController(
                IGetAllCompaniesUseCase getAllCompaniesUseCase,
                IGetCompanyByIdUseCase getCompanyByIdUseCase,
                ICreateCompanyUseCase createCompanyUseCase,
                IUpdateCompanyUseCase updateCompanyUseCase,
                IDeleteCompanyByIdUseCase deleteCompanyByIdUseCase)
        {
            _getAllCompaniesUseCase = getAllCompaniesUseCase;
            _getCompanyByIdUseCase = getCompanyByIdUseCase;
            _createCompanyUseCase = createCompanyUseCase;
            _updateCompanyUseCase = updateCompanyUseCase;
            _deleteCompanyByIdUseCase = deleteCompanyByIdUseCase;
        }
        // GET: Companies
        public async Task<ActionResult> Index()
        {
            IList<Company> companies = await _getAllCompaniesUseCase.ExecuteAsync();
            return View(companies);
        }

        // GET: Companies/Details/5
        public async Task<ActionResult> Details(int id)
        {
            Company company = await _getCompanyByIdUseCase.ExecuteAsync(id);
            return View(company);
        }

        // GET: Companies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Company company)
        {
            try
            {
                // TODO: Add insert logic here

                await _createCompanyUseCase.ExecuteAsync(company);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Companies/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Companies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Companies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Companies/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}