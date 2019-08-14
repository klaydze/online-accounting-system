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
    public class ChartOfAccountsController : Controller
    {
        private readonly IChartOfAccountService ChartOfAccountService;
        private readonly IAccountTypeService AccountTypeService;

        public ChartOfAccountsController(IChartOfAccountService chartOfAccountService, IAccountTypeService accountTypeService)
        {
            ChartOfAccountService = chartOfAccountService;
            AccountTypeService = accountTypeService;
        }

        // GET: ChartOfAccounts
        public async Task<IActionResult> Index() => View(await ChartOfAccountService.GetAllAsync());

        // GET: ChartOfAccounts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chartOfAccount = await ChartOfAccountService.GetByIDAsync(id);
            if (chartOfAccount == null)
            {
                return NotFound();
            }

            return View(chartOfAccount);
        }

        // GET: ChartOfAccounts/Create
        public async Task<IActionResult> Create()
        {
            ViewData["AccountTypes"] = new SelectList(await AccountTypeService.GetAllAsync(), "AccountTypeID", "Description");
            return View();
        }

        // POST: ChartOfAccounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountID,Code,Title,Description,Nature,GroupID,AccountTypeID,Active")] ChartOfAccountModel chartOfAccount)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                chartOfAccount.AccountID = Guid.NewGuid();
                await ChartOfAccountService.CreateAsync(chartOfAccount);
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountTypes"] = new SelectList(await AccountTypeService.GetAllAsync(), "AccountTypeID", "Description");
            return View(chartOfAccount);
        }

        // GET: ChartOfAccounts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chartOfAccount = await ChartOfAccountService.GetByIDAsync(id);
            if (chartOfAccount == null)
            {
                return NotFound();
            }
            ViewData["AccountTypes"] = new SelectList(await AccountTypeService.GetAllAsync(), "AccountTypeID", "Description");
            return View(chartOfAccount);
        }

        // POST: ChartOfAccounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("AccountID, Code, Title, Description, Nature, GroupID, AccountTypeID, Active, RowVersion")] ChartOfAccountModel chartOfAccount)
        {
            if (id != chartOfAccount.AccountID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await ChartOfAccountService.UpdateAsync(chartOfAccount);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            ViewData["AccountTypes"] = new SelectList(await AccountTypeService.GetAllAsync(), "AccountTypeID", "Description");
            return View(chartOfAccount);
        }

        // GET: ChartOfAccounts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chartOfAccount = await ChartOfAccountService.GetByIDAsync(id);
            if (chartOfAccount == null)
            {
                return NotFound();
            }

            return View(chartOfAccount);
        }

        // POST: ChartOfAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var chartOfAccount = await ChartOfAccountService.GetByIDAsync(id);
            await ChartOfAccountService.DeleteAsync(chartOfAccount);
            return RedirectToAction(nameof(Index));
        }
    }
}