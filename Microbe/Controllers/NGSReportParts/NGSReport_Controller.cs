using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Microbe.Controllers.NGSReportParts
{
    public class NGSReport_Controller : Controller
    {
        public IActionResult Index()
        {
           



            return View();
        }

    }
    public ActionResult GenerateReport()
    {
        string apiKey = "bd61ef1b-d55c-4c63-a558-44ed4e12cbc6";
        string url = "http://microbe.azurewebsites.net";

        using (var client = new HttpClient())
        {
            // Build the conversion options
            var content = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string="">("apikey", apiKey),
        new KeyValuePair<string, string="">("value", url)
    });

            var result = client.PostAsync("http://api.html2pdfrocket.com/pdf", content).Result;

            if (result.IsSuccessStatusCode)
            {
                MemoryStream stream = new MemoryStream(result.Content.ReadAsByteArrayAsync().Result);
                return File(stream, "application/pdf", "MyPdfFile.pdf")        }
    }


}