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
    public class NGS_TTLPhylumClassificationResultsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NGS_TTLPhylumClassificationResultsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NGS_
        public ActionResult Index(string sampleName, string ProjectID)
        {
            var ClassResults = from b in _context.NGS_TTLPhylumClassificationResults

                               select b;

            if (!String.IsNullOrEmpty(sampleName))
            {
                ClassResults = ClassResults.Where(s => s.sampleName == sampleName);
            }
            if (!String.IsNullOrEmpty(ProjectID))
            {
                ClassResults = ClassResults.Where(m => m.ProjectID == ProjectID);
            }

            ClassResults = ClassResults.OrderByDescending(s => s.numHits);


            if (ClassResults == null)
            {
                return NotFound();
            }
            return PartialView(ClassResults.AsNoTracking().Take(50).ToListAsync());

        }
        // GET: ClassResults/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ClassResults = _context.NGS_GenClassificationResults
                .SingleOrDefaultAsync(m => m.GenClassificationResultsTableID == id);
            if (ClassResults == null)
            {
                return NotFound();
            }

            return PartialView(ClassResults);
        }
    }
}