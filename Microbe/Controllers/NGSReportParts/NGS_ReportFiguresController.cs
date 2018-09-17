using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microbe.Data;
using Microbe.Models.NGSReportParts;

namespace Microbe.Controllers.NGSReportParts
{
    public class NGS_ReportFiguresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NGS_ReportFiguresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NGS_
        public async Task<IActionResult> Index(string sampleName, string ProjectID, string FigureType)
        {
            var ClassResults = from b in _context.NGS_ReportFigures
                          
                              select b;

            if (!String.IsNullOrEmpty(sampleName))
            {
                ClassResults = ClassResults.Where(s => s.SampleName == sampleName);
            }
            if (!String.IsNullOrEmpty(ProjectID))
            {
                ClassResults = ClassResults.Where(m => m.ProjectID == ProjectID);
            }
            if (!String.IsNullOrEmpty(FigureType))
            {
                ClassResults = ClassResults.Where(m => m.FigureType == FigureType);
            }

            if (ClassResults == null)
            {
                return NotFound();
            }
            return View(await ClassResults.AsNoTracking().Take(50).ToListAsync());
            
        }
        // GET: ClassResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ClassResults = await _context.NGS_ReportFigures
                .SingleOrDefaultAsync(m => m.NGS_ReportFiguresID == id);
            if (ClassResults == null)
            {
                return NotFound();
            }

            return View(ClassResults);
        }
    }
}