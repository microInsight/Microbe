using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microbe.Data;
using Microbe.Models.ReportSections;

namespace Microbe.Controllers
{
    public class ReportSectionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportSectionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReportSections
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReportSections.ToListAsync());
        }

        // GET: ReportSections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportSections = await _context.ReportSections
                .SingleOrDefaultAsync(m => m.ReportSectionID == id);
            if (reportSections == null)
            {
                return NotFound();
            }

            return View(reportSections);
        }

        // GET: ReportSections/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportSections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportSectionID,ReportDefinitionID,SectionOrder,SectionTitle,SectionDesc,ModifiedBy,createDate,modifiedDate")] ReportSections reportSections)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportSections);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportSections);
        }

        // GET: ReportSections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportSections = await _context.ReportSections.SingleOrDefaultAsync(m => m.ReportSectionID == id);
            if (reportSections == null)
            {
                return NotFound();
            }
            return View(reportSections);
        }

        // POST: ReportSections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportSectionID,ReportDefinitionID,SectionOrder,SectionTitle,SectionDesc,ModifiedBy,createDate,modifiedDate")] ReportSections reportSections)
        {
            if (id != reportSections.ReportSectionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportSections);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportSectionsExists(reportSections.ReportSectionID))
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
            return View(reportSections);
        }

        // GET: ReportSections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportSections = await _context.ReportSections
                .SingleOrDefaultAsync(m => m.ReportSectionID == id);
            if (reportSections == null)
            {
                return NotFound();
            }

            return View(reportSections);
        }

        // POST: ReportSections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportSections = await _context.ReportSections.SingleOrDefaultAsync(m => m.ReportSectionID == id);
            _context.ReportSections.Remove(reportSections);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportSectionsExists(int id)
        {
            return _context.ReportSections.Any(e => e.ReportSectionID == id);
        }
    }
}
