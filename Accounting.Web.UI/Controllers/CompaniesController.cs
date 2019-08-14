using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;

namespace Accounting.Web.UI.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ICompanyService CompanyService;

        public CompaniesController(ICompanyService companyService) => CompanyService = companyService;

        // GET: Companies
        public async Task<IActionResult> Index() => View(await CompanyService.GetAllAsync());

        // GET: Companies/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await CompanyService.GetByIDAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // GET: Companies/Create
        public IActionResult Create() => View();

        // POST: Companies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyID,CompanyName,Address1,Address2,Phone,Mobile,TIN")] CompanyModel company)
        {
            if (ModelState.IsValid)
            {
                company.CompanyID = Guid.NewGuid();
                await CompanyService.CreateAsync(company);
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Companies/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await CompanyService.GetByIDAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CompanyID,CompanyName,Address1,Address2,Phone,Mobile,TIN,RowVersion")] CompanyModel company)
        {
            if (id != company.CompanyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await CompanyService.UpdateAsync(company);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(company);
        }

        // GET: Companies/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await CompanyService.GetByIDAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var company = await CompanyService.GetByIDAsync(id);
            await CompanyService.DeleteAsync(company);
            return RedirectToAction(nameof(Index));
        }
    }
}
