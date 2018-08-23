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
    public class ClientProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClientProjects
        public async Task<IActionResult> Index(string searchString)
        {
            var Clients = from c in _context.ClientProjects
                         select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                Clients = Clients.Where(s => s.ClientName.Contains(searchString));
            }

            return View(await _context.ClientProjects.ToListAsync());
        }

        // GET: ClientProjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientProjects = await _context.ClientProjects
                .SingleOrDefaultAsync(m => m.id == id);
            if (clientProjects == null)
            {
                return NotFound();
            }

            return View(clientProjects);
        }

        // GET: ClientProjects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ClientName,ProjectName,Report,OutputToScreen,Genwiz")] ClientProjects clientProjects)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientProjects);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientProjects);
        }

        // GET: ClientProjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientProjects = await _context.ClientProjects.SingleOrDefaultAsync(m => m.id == id);
            if (clientProjects == null)
            {
                return NotFound();
            }
            return View(clientProjects);
        }

        // POST: ClientProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ClientName,ProjectName,Report,OutputToScreen,Genwiz")] ClientProjects clientProjects)
        {
            if (id != clientProjects.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientProjects);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientProjectsExists(clientProjects.id))
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
            return View(clientProjects);
        }

        // GET: ClientProjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientProjects = await _context.ClientProjects
                .SingleOrDefaultAsync(m => m.id == id);
            if (clientProjects == null)
            {
                return NotFound();
            }

            return View(clientProjects);
        }

        // POST: ClientProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientProjects = await _context.ClientProjects.SingleOrDefaultAsync(m => m.id == id);
            _context.ClientProjects.Remove(clientProjects);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientProjectsExists(int id)
        {
            return _context.ClientProjects.Any(e => e.id == id);
        }
    }
}
