using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microbe.Data;
using Microbe.Models.ReportModels;

namespace Microbe.Controllers.ProjectInformationControllers
{
    public class ProjectReportParametersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectReportParametersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectReportParameters
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectReportParameters.ToListAsync());
        }

        // GET: ProjectReportParameters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectReportParameters = await _context.ProjectReportParameters
                .SingleOrDefaultAsync(m => m.ID == id);
            if (projectReportParameters == null)
            {
                return NotFound();
            }

            return View(projectReportParameters);
        }

        // GET: ProjectReportParameters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectReportParameters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ClientProjectReportsID,SpecialLabel,MinimumRange,MaximumRange,GraphsPerPage,DataFilter,SpecialNote,ModifiedBy,createDate,modifiedDate")] ProjectReportParameters projectReportParameters)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectReportParameters);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectReportParameters);
        }

        // GET: ProjectReportParameters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectReportParameters = await _context.ProjectReportParameters.SingleOrDefaultAsync(m => m.ID == id);
            if (projectReportParameters == null)
            {
                return NotFound();
            }
            return View(projectReportParameters);
        }

        // POST: ProjectReportParameters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ClientProjectReportsID,SpecialLabel,MinimumRange,MaximumRange,GraphsPerPage,DataFilter,SpecialNote,ModifiedBy,createDate,modifiedDate")] ProjectReportParameters projectReportParameters)
        {
            if (id != projectReportParameters.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectReportParameters);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectReportParametersExists(projectReportParameters.ID))
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
            return View(projectReportParameters);
        }

        // GET: ProjectReportParameters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectReportParameters = await _context.ProjectReportParameters
                .SingleOrDefaultAsync(m => m.ID == id);
            if (projectReportParameters == null)
            {
                return NotFound();
            }

            return View(projectReportParameters);
        }

        // POST: ProjectReportParameters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectReportParameters = await _context.ProjectReportParameters.SingleOrDefaultAsync(m => m.ID == id);
            _context.ProjectReportParameters.Remove(projectReportParameters);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectReportParametersExists(int id)
        {
            return _context.ProjectReportParameters.Any(e => e.ID == id);
        }
    }
}
