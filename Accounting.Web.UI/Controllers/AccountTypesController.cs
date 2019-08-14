using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;

namespace Accounting.Web.UI.Controllers
{
    public class AccountTypesController : Controller
    {
        private readonly IAccountTypeService AccountTypeService;

        public AccountTypesController(IAccountTypeService accountTypeService) => AccountTypeService = accountTypeService;

        // GET: AccountTypes
        public async Task<IActionResult> Index() => View(await AccountTypeService.GetAllAsync());

        // GET: AccountTypes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountType = await AccountTypeService.GetByIDAsync(id);
            if (accountType == null)
            {
                return NotFound();
            }

            return View(accountType);
        }

        // GET: AccountTypes/Create
        public IActionResult Create() => View();

        // POST: AccountTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountTypeID,Code,Category,Description")] AccountTypeModel accountType)
        {
            if (ModelState.IsValid)
            {
                accountType.AccountTypeID = Guid.NewGuid();
                await AccountTypeService.CreateAsync(accountType);
                return RedirectToAction(nameof(Index));
            }
            return View(accountType);
        }

        // GET: AccountTypes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountType = await AccountTypeService.GetByIDAsync(id);
            if (accountType == null)
            {
                return NotFound();
            }
            return View(accountType);
        }

        // POST: AccountTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("AccountTypeID,Code,Category,Description,RowVersion")] AccountTypeModel accountType)
        {
            if (id != accountType.AccountTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await AccountTypeService.UpdateAsync(accountType);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(accountType);
        }

        // GET: AccountTypes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountType = await AccountTypeService.GetByIDAsync(id);
            if (accountType == null)
            {
                return NotFound();
            }

            return View(accountType);
        }

        // POST: AccountTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var accountType = await AccountTypeService.GetByIDAsync(id);
            await AccountTypeService.DeleteAsync(accountType);
            return RedirectToAction(nameof(Index));
        }
    }
}
