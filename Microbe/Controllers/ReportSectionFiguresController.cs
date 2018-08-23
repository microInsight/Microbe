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
    public class ReportSectionFiguresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportSectionFiguresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReportSectionFigures
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReportSectionFigures.ToListAsync());
        }

        // GET: ReportSectionFigures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportSectionFigures = await _context.ReportSectionFigures
                .SingleOrDefaultAsync(m => m.ReportSectionFigureID == id);
            if (reportSectionFigures == null)
            {
                return NotFound();
            }

            return View(reportSectionFigures);
        }

        // GET: ReportSectionFigures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportSectionFigures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportSectionFigureID,ReportSectionID,SectionFigureOrder,FigureType,FigureDesc,FigureSuffix")] ReportSectionFigures reportSectionFigures)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportSectionFigures);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportSectionFigures);
        }

        // GET: ReportSectionFigures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportSectionFigures = await _context.ReportSectionFigures.SingleOrDefaultAsync(m => m.ReportSectionFigureID == id);
            if (reportSectionFigures == null)
            {
                return NotFound();
            }
            return View(reportSectionFigures);
        }

        // POST: ReportSectionFigures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportSectionFigureID,ReportSectionID,SectionFigureOrder,FigureType,FigureDesc,FigureSuffix")] ReportSectionFigures reportSectionFigures)
        {
            if (id != reportSectionFigures.ReportSectionFigureID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportSectionFigures);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportSectionFiguresExists(reportSectionFigures.ReportSectionFigureID))
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
            return View(reportSectionFigures);
        }

        // GET: ReportSectionFigures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportSectionFigures = await _context.ReportSectionFigures
                .SingleOrDefaultAsync(m => m.ReportSectionFigureID == id);
            if (reportSectionFigures == null)
            {
                return NotFound();
            }

            return View(reportSectionFigures);
        }

        // POST: ReportSectionFigures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportSectionFigures = await _context.ReportSectionFigures.SingleOrDefaultAsync(m => m.ReportSectionFigureID == id);
            _context.ReportSectionFigures.Remove(reportSectionFigures);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportSectionFiguresExists(int id)
        {
            return _context.ReportSectionFigures.Any(e => e.ReportSectionFigureID == id);
        }
    }
}
