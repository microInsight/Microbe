﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Microbe.Controllers.NGSReportParts
{
    public class TTLPhylumClassificationResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}