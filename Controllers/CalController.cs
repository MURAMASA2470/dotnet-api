using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet.Models;

namespace dotnet.Controllers
{
    public class CalController : Controller
    {
        private readonly ILogger<CalController> _logger;

        public CalController(ILogger<CalController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int value)
        {
            var val = new { result = value * 2 };
            return Ok(val);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
