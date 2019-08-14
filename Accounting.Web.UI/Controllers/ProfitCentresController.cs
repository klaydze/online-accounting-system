using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Accounting.Web.UI.Controllers
{
    public class ProfitCentresController : Controller
    {
        private readonly IProfitCentreService ProfitCentreService;
        private readonly ICompanyService CompanyService;

        public ProfitCentresController(IProfitCentreService profitCentreService, ICompanyService companyService)
        {
            ProfitCentreService = profitCentreService;
            CompanyService = companyService;
        }

        // GET: ProfitCentres
        public async Task<IActionResult> Index() => View(await ProfitCentreService.GetAllAsync());

        // GET: ProfitCentres/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profitCentre = await ProfitCentreService.GetByIDAsync(id);
            if (profitCentre == null)
            {
                return NotFound();
            }

            return View(profitCentre);
        }

        // GET: ProfitCentres/Create
        public async Task<IActionResult> Create()
        {
            ViewData["Companies"] = new SelectList(await CompanyService.GetAllAsync(), "CompanyID", "CompanyName");
            return View();
        }

        // POST: ProfitCentres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfitCentreID,ProfitCentreName,ContactNo,Mobile,Address1,Address2,Address3,TradeName,ProfitCentreType,CompanyID,Active")] ProfitCentreModel profitCentre)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                profitCentre.ProfitCentreID = Guid.NewGuid();
                await ProfitCentreService.CreateAsync(profitCentre);
                return RedirectToAction(nameof(Index));
            }
            ViewData["Companies"] = new SelectList(await CompanyService.GetAllAsync(), "CompanyID", "CompanyName");
            return View(profitCentre);
        }

        // GET: ProfitCentres/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profitCentre = await ProfitCentreService.GetByIDAsync(id);
            if (profitCentre == null)
            {
                return NotFound();
            }
            ViewData["Companies"] = new SelectList(await CompanyService.GetAllAsync(), "CompanyID", "CompanyName");
            return View(profitCentre);
        }

        // POST: ProfitCentres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProfitCentreID,ProfitCentreName,ContactNo,Mobile,Address1,Address2,Address3,TradeName,ProfitCentreType,CompanyID,Active,RowVersion")] ProfitCentreModel profitCentre)
        {
            if (id != profitCentre.ProfitCentreID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await ProfitCentreService.UpdateAsync(profitCentre);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            ViewData["Companies"] = new SelectList(await CompanyService.GetAllAsync(), "CompanyID", "CompanyName");
            return View(profitCentre);
        }

        // GET: ProfitCentres/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profitCentre = await ProfitCentreService.GetByIDAsync(id);
            if (profitCentre == null)
            {
                return NotFound();
            }

            return View(profitCentre);
        }

        // POST: ProfitCentres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var profitCentre = await ProfitCentreService.GetByIDAsync(id);
            await ProfitCentreService.DeleteAsync(profitCentre);
            return RedirectToAction(nameof(Index));
        }
    }
}
