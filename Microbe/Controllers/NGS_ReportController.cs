using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microbe.Data;
using Microbe.Models.ReportModels;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Collections.Specialized;
using System.IO;

namespace Microbe.Controllers
{
    public class NGS_ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NGS_ReportController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NGS_Report

        public async Task<IActionResult> Index(string searchString)
        {
            var NGS_Report = from b in _context.NGS_Report
                                select b;

            

            if (searchString == null)
            {
                NGS_Report = NGS_Report.Where(s => s.ProjectID == "");
            }
            else
            {
                NGS_Report = NGS_Report.Where(s => s.ProjectID==searchString);
            }
            NGS_Report = NGS_Report.OrderBy(s => s.NGS_ReportID);


            if (NGS_Report == null)
            {
                return NotFound();
            }
            return View(await NGS_Report.AsNoTracking().ToListAsync());

        }

        // GET: NGS_Report/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nGS_Report = await _context.NGS_Report
                .SingleOrDefaultAsync(m => m.ProjectID == id);
            if (nGS_Report == null)
            {
                return NotFound();
            }

            return View(nGS_Report);
        }

        // GET: NGS_Report/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NGS_Report/Create
        // To protect from overp osting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectID,htmlLine")] NGS_Report nGS_Report)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nGS_Report);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nGS_Report);
        }

        // GET: NGS_Report/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nGS_Report = await _context.NGS_Report.SingleOrDefaultAsync(m => m.ProjectID == id);
            if (nGS_Report == null)
            {
                return NotFound();
            }
            return View(nGS_Report);
        }

        // POST: NGS_Report/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ProjectID,htmlLine")] NGS_Report nGS_Report)
        {
            if (id != nGS_Report.ProjectID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nGS_Report);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NGS_ReportExists(nGS_Report.ProjectID))
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
            return View(nGS_Report);
        }

        // GET: NGS_Report/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nGS_Report = await _context.NGS_Report
                .SingleOrDefaultAsync(m => m.ProjectID == id);
            if (nGS_Report == null)
            {
                return NotFound();
            }

            return View(nGS_Report);
        }

        // POST: NGS_Report/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nGS_Report = await _context.NGS_Report.SingleOrDefaultAsync(m => m.ProjectID == id);
            _context.NGS_Report.Remove(nGS_Report);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NGS_ReportExists(string id)
        {
            return _context.NGS_Report.Any(e => e.ProjectID == id);
        }
    }
}
