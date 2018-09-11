using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microbe.Data;
using Microbe.Models.ReportModels;

namespace Microbe.Controllers
{
    public class ReportTitlePageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportTitlePageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReportTitlePage
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReportTitlePages.ToListAsync());
        }

        // GET: ReportTitlePage/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ReportTitlePage = await _context.ReportTitlePages
                .SingleOrDefaultAsync(m => m.ReportTitlePageID == id);
            if (ReportTitlePage == null)
            {
                return NotFound();
            }

            return View(ReportTitlePage);
        }

        // GET: ReportTitlePage/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportTitlePage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportTitlePageID,ReportDefinitionID,SectionOrder,SectionTitle,SectionDesc,ModifiedBy,createDate,modifiedDate")] ReportTitlePage ReportTitlePage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ReportTitlePage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ReportTitlePage);
        }

        // GET: ReportTitlePage/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ReportTitlePage = await _context.ReportTitlePages.SingleOrDefaultAsync(m => m.ReportTitlePageID == id);
            if (ReportTitlePage == null)
            {
                return NotFound();
            }
            return View(ReportTitlePage);
        }

        // POST: ReportTitlePage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportTitlePageID,ReportDefinitionID,SectionOrder,SectionTitle,SectionDesc,ModifiedBy,createDate,modifiedDate")] ReportTitlePage ReportTitlePage)
        {
            if (id != ReportTitlePage.ReportTitlePageID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ReportTitlePage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportTitlePageExists(ReportTitlePage.ReportTitlePageID))
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
            return View(ReportTitlePage);
        }

        // GET: ReportTitlePage/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ReportTitlePage = await _context.ReportTitlePages
                .SingleOrDefaultAsync(m => m.ReportTitlePageID == id);
            if (ReportTitlePage == null)
            {
                return NotFound();
            }

            return View(ReportTitlePage);
        }

        // POST: ReportTitlePage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ReportTitlePage = await _context.ReportTitlePages.SingleOrDefaultAsync(m => m.ReportTitlePageID == id);
            _context.ReportTitlePages.Remove(ReportTitlePage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportTitlePageExists(int id)
        {
            return _context.ReportTitlePages.Any(e => e.ReportTitlePageID == id);
        }
    }
}
