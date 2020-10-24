using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using maritza_s.Models;

namespace maritza_s.Controllers
{
    public class PlatosController : Controller
    {
        private readonly ILogger<PlatosController> _logger;

        public PlatosController(ILogger<PlatosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Platos()
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