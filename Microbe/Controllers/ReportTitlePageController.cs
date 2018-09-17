using System;
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
    public class ReportTitlePageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportTitlePageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReportTitlePage
        public async Task<IActionResult> Index()
        {
            return PartialView(_context.ReportTitlePages.ToList());
        }

        // GET: ReportTitlePage/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ReportTitlePage = await _context.ReportTitlePages
                .SingleOrDefaultAsync(m => m.ReportTitlePageID == id);
            if (ReportTitlePage == null)
            {
                return NotFound();
            }

            return PartialView(ReportTitlePage);
        }

    }
}
