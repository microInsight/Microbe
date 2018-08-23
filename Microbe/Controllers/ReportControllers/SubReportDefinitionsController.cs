using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microbe.Data;
using Microbe.Models.ReportModels;

namespace Microbe.Controllers.ReportControllers
{
    public class SubReportDefinitionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubReportDefinitionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SubReportDefinitions
        public async Task<IActionResult> Index()
        {
            return View(await _context.SubReportDefinitions.ToListAsync());
        }

        // GET: SubReportDefinitions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subReportDefinitions = await _context.SubReportDefinitions
                .SingleOrDefaultAsync(m => m.id == id);
            if (subReportDefinitions == null)
            {
                return NotFound();
            }

            return View(subReportDefinitions);
        }

        // GET: SubReportDefinitions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubReportDefinitions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ReportDefinitionsID,ReportType,DefinitionDesc,ReportFunction,ModifiedBy,createDate,modifiedDate")] SubReportDefinitions subReportDefinitions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subReportDefinitions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subReportDefinitions);
        }

        // GET: SubReportDefinitions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subReportDefinitions = await _context.SubReportDefinitions.SingleOrDefaultAsync(m => m.id == id);
            if (subReportDefinitions == null)
            {
                return NotFound();
            }
            return View(subReportDefinitions);
        }

        // POST: SubReportDefinitions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ReportDefinitionsID,ReportType,DefinitionDesc,ReportFunction,ModifiedBy,createDate,modifiedDate")] SubReportDefinitions subReportDefinitions)
        {
            if (id != subReportDefinitions.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subReportDefinitions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubReportDefinitionsExists(subReportDefinitions.id))
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
            return View(subReportDefinitions);
        }

        // GET: SubReportDefinitions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subReportDefinitions = await _context.SubReportDefinitions
                .SingleOrDefaultAsync(m => m.id == id);
            if (subReportDefinitions == null)
            {
                return NotFound();
            }

            return View(subReportDefinitions);
        }

        // POST: SubReportDefinitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subReportDefinitions = await _context.SubReportDefinitions.SingleOrDefaultAsync(m => m.id == id);
            _context.SubReportDefinitions.Remove(subReportDefinitions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubReportDefinitionsExists(int id)
        {
            return _context.SubReportDefinitions.Any(e => e.id == id);
        }
    }
}
