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
    public class LIMS_BranchesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LIMS_BranchesController(ApplicationDbContext context)
        {
            _context = context;
        } 

        // GET: LIMS_Branches
        public async Task<IActionResult> Index(int? ID)
        {
            if(ID==null)
            {
                return NotFound();
            }   
            var lIMS_Branches = from b in _context.LIMS_Branches
                                select b;
            lIMS_Branches = lIMS_Branches.Where(s => s.ClientID.Equals(ID));
            lIMS_Branches = lIMS_Branches.OrderBy(s => s.Branch_Display);
                
            if (lIMS_Branches == null)
            {
                return NotFound();
            }
            return View(await lIMS_Branches.AsNoTracking().ToListAsync());

        }

        // GET: LIMS_Branches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMS_Branches = await _context.LIMS_Branches
                .SingleOrDefaultAsync(m => m.BranchID == id);
            if (lIMS_Branches == null)
            {
                return NotFound();
            }

            return View(lIMS_Branches);
        }

        // GET: LIMS_Branches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LIMS_Branches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BranchID,ClientID,Abbr,Branch_Name,Branch_Display,Branch_Type,Address_1,Address_2,Address_3,City,StateOrProvince,PostalCode,CountryRegion,Phone,Fax,Notes,active,EDD,DateAdded")] LIMS_Branches lIMS_Branches)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lIMS_Branches);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lIMS_Branches);
        }

        // GET: LIMS_Branches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMS_Branches = await _context.LIMS_Branches.SingleOrDefaultAsync(m => m.BranchID == id);
            if (lIMS_Branches == null)
            {
                return NotFound();
            }
            return View(lIMS_Branches);
        }

        // POST: LIMS_Branches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BranchID,ClientID,Abbr,Branch_Name,Branch_Display,Branch_Type,Address_1,Address_2,Address_3,City,StateOrProvince,PostalCode,CountryRegion,Phone,Fax,Notes,active,EDD,DateAdded")] LIMS_Branches lIMS_Branches)
        {
            if (id != lIMS_Branches.BranchID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lIMS_Branches);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LIMS_BranchesExists(lIMS_Branches.BranchID))
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
            return View(lIMS_Branches);
        }

        // GET: LIMS_Branches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMS_Branches = await _context.LIMS_Branches
                .SingleOrDefaultAsync(m => m.BranchID == id);
            if (lIMS_Branches == null)
            {
                return NotFound();
            }

            return View(lIMS_Branches);
        }

        // POST: LIMS_Branches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lIMS_Branches = await _context.LIMS_Branches.SingleOrDefaultAsync(m => m.BranchID == id);
            _context.LIMS_Branches.Remove(lIMS_Branches);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LIMS_BranchesExists(int id)
        {
            return _context.LIMS_Branches.Any(e => e.BranchID == id);
        }
    }
}
