using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accounting.Domain;
using Accounting.Domain.Entities;

namespace Accounting.Web.UI.Controllers
{
    public class ProfitCentreAccountsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfitCentreAccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProfitCentreAccounts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ProfitCentreAccounts.Include(p => p.ChartOfAccount).Include(p => p.ProfitCentre);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ProfitCentreAccounts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profitCentreAccount = await _context.ProfitCentreAccounts
                .Include(p => p.ChartOfAccount)
                .Include(p => p.ProfitCentre)
                .FirstOrDefaultAsync(m => m.PCAccountID == id);
            if (profitCentreAccount == null)
            {
                return NotFound();
            }

            return View(profitCentreAccount);
        }

        // GET: ProfitCentreAccounts/Create
        public IActionResult Create()
        {
            ViewData["AccountID"] = new SelectList(_context.ChartOfAccounts, "AccountID", "AccountID");
            ViewData["ProfitCentreID"] = new SelectList(_context.ProfitCentres, "ProfitCentreID", "ProfitCentreID");
            return View();
        }

        // POST: ProfitCentreAccounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PCAccountID,ProfitCentreID,AccountID,Active,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,RowVersion")] ProfitCentreAccount profitCentreAccount)
        {
            if (ModelState.IsValid)
            {
                profitCentreAccount.PCAccountID = Guid.NewGuid();
                _context.Add(profitCentreAccount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountID"] = new SelectList(_context.ChartOfAccounts, "AccountID", "AccountID", profitCentreAccount.AccountID);
            ViewData["ProfitCentreID"] = new SelectList(_context.ProfitCentres, "ProfitCentreID", "ProfitCentreID", profitCentreAccount.ProfitCentreID);
            return View(profitCentreAccount);
        }

        // GET: ProfitCentreAccounts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profitCentreAccount = await _context.ProfitCentreAccounts.FindAsync(id);
            if (profitCentreAccount == null)
            {
                return NotFound();
            }
            ViewData["AccountID"] = new SelectList(_context.ChartOfAccounts, "AccountID", "AccountID", profitCentreAccount.AccountID);
            ViewData["ProfitCentreID"] = new SelectList(_context.ProfitCentres, "ProfitCentreID", "ProfitCentreID", profitCentreAccount.ProfitCentreID);
            return View(profitCentreAccount);
        }

        // POST: ProfitCentreAccounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PCAccountID,ProfitCentreID,AccountID,Active,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,RowVersion")] ProfitCentreAccount profitCentreAccount)
        {
            if (id != profitCentreAccount.PCAccountID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profitCentreAccount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfitCentreAccountExists(profitCentreAccount.PCAccountID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountID"] = new SelectList(_context.ChartOfAccounts, "AccountID", "AccountID", profitCentreAccount.AccountID);
            ViewData["ProfitCentreID"] = new SelectList(_context.ProfitCentres, "ProfitCentreID", "ProfitCentreID", profitCentreAccount.ProfitCentreID);
            return View(profitCentreAccount);
        }

        // GET: ProfitCentreAccounts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profitCentreAccount = await _context.ProfitCentreAccounts
                .Include(p => p.ChartOfAccount)
                .Include(p => p.ProfitCentre)
                .FirstOrDefaultAsync(m => m.PCAccountID == id);
            if (profitCentreAccount == null)
            {
                return NotFound();
            }

            return View(profitCentreAccount);
        }

        // POST: ProfitCentreAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var profitCentreAccount = await _context.ProfitCentreAccounts.FindAsync(id);
            _context.ProfitCentreAccounts.Remove(profitCentreAccount);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfitCentreAccountExists(Guid id)
        {
            return _context.ProfitCentreAccounts.Any(e => e.PCAccountID == id);
        }
    }
}
