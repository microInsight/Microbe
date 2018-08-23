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
    public class LIMS_ProjectClientController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LIMS_ProjectClientController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LIMS_ProjectClient
        public async Task<IActionResult> Index(int? ID)
        {
            if (ID == null)
            {
                return NotFound();
            }
            var lIMS_ProjectClient = from b in _context.LIMS_ProjectClient
                                select b;
            lIMS_ProjectClient = lIMS_ProjectClient.Where(s => s.BranchID.Equals(ID));
            lIMS_ProjectClient = lIMS_ProjectClient.OrderBy(s => s.ProjectID);

            if (lIMS_ProjectClient == null)
            {
                return NotFound();
            }
            return View(await lIMS_ProjectClient.AsNoTracking().ToListAsync());
        }

        // GET: LIMS_ProjectClient/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMS_ProjectClient = await _context.LIMS_ProjectClient
                .SingleOrDefaultAsync(m => m.ProjectClientID == id);
            if (lIMS_ProjectClient == null)
            {
                return NotFound();
            }

            return View(lIMS_ProjectClient);
        }

        // GET: LIMS_ProjectClient/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LIMS_ProjectClient/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectClientID,ProjectID,BranchID,sort,Branch_Address1,Branch_Address2,Branch_Address3,Branch_City,Branch_StateOrProvince,Branch_PostalCode,Branch_CountryRegion,Branch_Phone,Branch_Fax,Branch_Notes,Contact_Name,Contact_Title,Contact_Dept,Contact_Phone,Contact_PhoneExt,Contact_Fax,Contact_Email,Contact_Method,Contact_Notes,active,LastChangeBy,LastChangeDate,LastChangeType,ClientIndex")] LIMS_ProjectClient lIMS_ProjectClient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lIMS_ProjectClient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lIMS_ProjectClient);
        }

        // GET: LIMS_ProjectClient/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMS_ProjectClient = await _context.LIMS_ProjectClient.SingleOrDefaultAsync(m => m.ProjectClientID == id);
            if (lIMS_ProjectClient == null)
            {
                return NotFound();
            }
            return View(lIMS_ProjectClient);
        }

        // POST: LIMS_ProjectClient/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectClientID,ProjectID,BranchID,sort,Branch_Address1,Branch_Address2,Branch_Address3,Branch_City,Branch_StateOrProvince,Branch_PostalCode,Branch_CountryRegion,Branch_Phone,Branch_Fax,Branch_Notes,Contact_Name,Contact_Title,Contact_Dept,Contact_Phone,Contact_PhoneExt,Contact_Fax,Contact_Email,Contact_Method,Contact_Notes,active,LastChangeBy,LastChangeDate,LastChangeType,ClientIndex")] LIMS_ProjectClient lIMS_ProjectClient)
        {
            if (id != lIMS_ProjectClient.ProjectClientID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lIMS_ProjectClient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LIMS_ProjectClientExists(lIMS_ProjectClient.ProjectClientID))
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
            return View(lIMS_ProjectClient);
        }

        // GET: LIMS_ProjectClient/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMS_ProjectClient = await _context.LIMS_ProjectClient
                .SingleOrDefaultAsync(m => m.ProjectClientID == id);
            if (lIMS_ProjectClient == null)
            {
                return NotFound();
            }

            return View(lIMS_ProjectClient);
        }

        // POST: LIMS_ProjectClient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lIMS_ProjectClient = await _context.LIMS_ProjectClient.SingleOrDefaultAsync(m => m.ProjectClientID == id);
            _context.LIMS_ProjectClient.Remove(lIMS_ProjectClient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LIMS_ProjectClientExists(int id)
        {
            return _context.LIMS_ProjectClient.Any(e => e.ProjectClientID == id);
        }
    }
}
