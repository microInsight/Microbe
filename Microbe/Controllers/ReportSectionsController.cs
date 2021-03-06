﻿using System;
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
    public class reportTitlePagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public reportTitlePagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: reportTitlePages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReportTitlePages.ToListAsync());
        }

        // GET: reportTitlePages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportTitlePages = await _context.ReportTitlePages
                .SingleOrDefaultAsync(m => m.ReportTitlePageID == id);
            if (reportTitlePages == null)
            {
                return NotFound();
            }

            return View(reportTitlePages);
        }

        // GET: reportTitlePages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: reportTitlePages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportTitlePageID,ReportDefinitionID,SectionOrder,SectionTitle,SectionDesc,ModifiedBy,createDate,modifiedDate")] ReportTitlePage reportTitlePage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportTitlePage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportTitlePage);
        }

        // GET: reportTitlePages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportTitlePages = await _context.ReportTitlePages.SingleOrDefaultAsync(m => m.ReportTitlePageID == id);
            if (reportTitlePages == null)
            {
                return NotFound();
            }
            return View(reportTitlePages);
        }

        // POST: reportTitlePages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportTitlePageID,ReportDefinitionID,SectionOrder,SectionTitle,SectionDesc,ModifiedBy,createDate,modifiedDate")] ReportTitlePage reportTitlePages)
        {
            if (id != reportTitlePages.ReportTitlePageID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportTitlePages);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!reportTitlePagesExists(reportTitlePages.ReportTitlePageID))
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
            return View(reportTitlePages);
        }

        // GET: reportTitlePages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportTitlePages = await _context.ReportTitlePages
                .SingleOrDefaultAsync(m => m.ReportTitlePageID == id);
            if (reportTitlePages == null)
            {
                return NotFound();
            }

            return View(reportTitlePages);
        }

        // POST: reportTitlePages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportTitlePages = await _context.ReportTitlePages.SingleOrDefaultAsync(m => m.ReportTitlePageID == id);
            _context.ReportTitlePages.Remove(reportTitlePages);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool reportTitlePagesExists(int id)
        {
            return _context.ReportTitlePages.Any(e => e.ReportTitlePageID == id);
        }
    }
}
