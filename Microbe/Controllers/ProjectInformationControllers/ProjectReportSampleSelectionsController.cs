using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microbe.Data;
using Microbe.Models.ProjectInformationModels;

namespace Microbe.Controllers.ProjectInformationControllers
{
    public class ProjectReportSampleSelectionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectReportSampleSelectionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectReportSampleSelections
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectReportSampleSelection.ToListAsync());
        }

        // GET: ProjectReportSampleSelections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectReportSampleSelection = await _context.ProjectReportSampleSelection
                .SingleOrDefaultAsync(m => m.id == id);
            if (projectReportSampleSelection == null)
            {
                return NotFound();
            }

            return View(projectReportSampleSelection);
        }

        // GET: ProjectReportSampleSelections/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectReportSampleSelections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ClientProjectReportsID,isSelected,PointColor,trendLine,ModifiedBy,createDate,modifiedDate")] ProjectReportSampleSelection projectReportSampleSelection)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectReportSampleSelection);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectReportSampleSelection);
        }

        // GET: ProjectReportSampleSelections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectReportSampleSelection = await _context.ProjectReportSampleSelection.SingleOrDefaultAsync(m => m.id == id);
            if (projectReportSampleSelection == null)
            {
                return NotFound();
            }
            return View(projectReportSampleSelection);
        }

        // POST: ProjectReportSampleSelections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ClientProjectReportsID,isSelected,PointColor,trendLine,ModifiedBy,createDate,modifiedDate")] ProjectReportSampleSelection projectReportSampleSelection)
        {
            if (id != projectReportSampleSelection.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectReportSampleSelection);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectReportSampleSelectionExists(projectReportSampleSelection.id))
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
            return View(projectReportSampleSelection);
        }

        // GET: ProjectReportSampleSelections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectReportSampleSelection = await _context.ProjectReportSampleSelection
                .SingleOrDefaultAsync(m => m.id == id);
            if (projectReportSampleSelection == null)
            {
                return NotFound();
            }

            return View(projectReportSampleSelection);
        }

        // POST: ProjectReportSampleSelections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectReportSampleSelection = await _context.ProjectReportSampleSelection.SingleOrDefaultAsync(m => m.id == id);
            _context.ProjectReportSampleSelection.Remove(projectReportSampleSelection);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectReportSampleSelectionExists(int id)
        {
            return _context.ProjectReportSampleSelection.Any(e => e.id == id);
        }
    }
}
