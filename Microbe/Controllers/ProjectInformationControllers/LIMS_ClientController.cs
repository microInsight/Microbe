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
    public class LIMS_ClientController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LIMS_ClientController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LIMS_Client
        public async Task<IActionResult> Index(string searchString)
        {
            var lIMS_Client = from b in _context.LIMS_Client
                                select b;
            
            if (searchString == null)
            {
                lIMS_Client = lIMS_Client.Where(s => s.DisplayName != "");
            }
            else
            {
                lIMS_Client = lIMS_Client.Where(s => s.DisplayName.Contains(searchString));
            }
            lIMS_Client = lIMS_Client.OrderBy(s => s.DisplayName);
            

            if (lIMS_Client == null)
            {
                return NotFound();
            }
            return View(await lIMS_Client.AsNoTracking().Take(50).ToListAsync());
        }

        // GET: LIMS_Client/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMS_Client = await _context.LIMS_Client
                .SingleOrDefaultAsync(m => m.ClientID == id);
            if (lIMS_Client == null)
            {
                return NotFound();
            }

            return View(lIMS_Client);
        }

        // GET: LIMS_Client/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LIMS_Client/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientID,DisplayName,CompanyName,ClientNotes,active,primaryinvname,secondaryinvname,DateAdded")] LIMS_Client lIMS_Client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lIMS_Client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lIMS_Client);
        }

        // GET: LIMS_Client/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMS_Client = await _context.LIMS_Client.SingleOrDefaultAsync(m => m.ClientID == id);
            if (lIMS_Client == null)
            {
                return NotFound();
            }
            return View(lIMS_Client);
        }

        // POST: LIMS_Client/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientID,DisplayName,CompanyName,ClientNotes,active,primaryinvname,secondaryinvname,DateAdded")] LIMS_Client lIMS_Client)
        {
            if (id != lIMS_Client.ClientID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lIMS_Client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LIMS_ClientExists(lIMS_Client.ClientID))
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
            return View(lIMS_Client);
        }

        // GET: LIMS_Client/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMS_Client = await _context.LIMS_Client
                .SingleOrDefaultAsync(m => m.ClientID == id);
            if (lIMS_Client == null)
            {
                return NotFound();
            }

            return View(lIMS_Client);
        }

        // POST: LIMS_Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lIMS_Client = await _context.LIMS_Client.SingleOrDefaultAsync(m => m.ClientID == id);
            _context.LIMS_Client.Remove(lIMS_Client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LIMS_ClientExists(int id)
        {
            return _context.LIMS_Client.Any(e => e.ClientID == id);
        }
    }
}
