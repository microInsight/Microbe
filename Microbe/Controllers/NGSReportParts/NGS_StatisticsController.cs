﻿using System;
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
    public class NGS_StatisticsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NGS_StatisticsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NGS_
        public async Task<IActionResult> Index(string sampleName, string ProjectID)
        {
            var ClassResults = from b in _context.NGS_Statistics

                               select b;

            if (!String.IsNullOrEmpty(sampleName))
            {
                ClassResults = ClassResults.Where(s => s.SampleName == sampleName);
            }
            if (!String.IsNullOrEmpty(ProjectID))
            {
                ClassResults = ClassResults.Where(m => m.ProjectID == ProjectID);
            }

            ClassResults = ClassResults.OrderByDescending(s => s.num_hits);


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

            var ClassResults = await _context.NGS_Statistics
                .SingleOrDefaultAsync(m => m.NGS_StatisticsID == id);
            if (ClassResults == null)
            {
                return NotFound();
            }

            return View(ClassResults);
        }
    }
}