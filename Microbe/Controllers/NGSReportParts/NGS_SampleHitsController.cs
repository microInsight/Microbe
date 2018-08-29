using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microbe.Data;
using Microbe.Models.NGSReportParts;


namespace Microbe.Controllers.NGSReportParts
{
    public class NGS_SampleHitsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NGS_SampleHitsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}