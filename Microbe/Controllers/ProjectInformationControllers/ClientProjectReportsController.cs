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
    public class ClientProjectReportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientProjectReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClientProjectReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClientProjectReports.ToListAsync());
        }

        // GET: ClientProjectReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientProjectReports = await _context.ClientProjectReports
                .SingleOrDefaultAsync(m => m.id == id);
            if (clientProjectReports == null)
            {
                return NotFound();
            }

            return View(clientProjectReports);
        }

        // GET: ClientProjectReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientProjectReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ClientProjectsID,ReportParametersID,ReportDefinitionsID,datafile")] ClientProjectReports clientProjectReports)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientProjectReports);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientProjectReports);
        }

        // GET: ClientProjectReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientProjectReports = await _context.ClientProjectReports.SingleOrDefaultAsync(m => m.id == id);
            if (clientProjectReports == null)
            {
                return NotFound();
            }
            return View(clientProjectReports);
        }

        // POST: ClientProjectReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ClientProjectsID,ReportParametersID,ReportDefinitionsID,datafile")] ClientProjectReports clientProjectReports)
        {
            if (id != clientProjectReports.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientProjectReports);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientProjectReportsExists(clientProjectReports.id))
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
            return View(clientProjectReports);
        }

        // GET: ClientProjectReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientProjectReports = await _context.ClientProjectReports
                .SingleOrDefaultAsync(m => m.id == id);
            if (clientProjectReports == null)
            {
                return NotFound();
            }

            return View(clientProjectReports);
        }

        // POST: ClientProjectReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientProjectReports = await _context.ClientProjectReports.SingleOrDefaultAsync(m => m.id == id);
            _context.ClientProjectReports.Remove(clientProjectReports);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientProjectReportsExists(int id)
        {
            return _context.ClientProjectReports.Any(e => e.id == id);
        }
    }
}
