using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using square.Models;

namespace squared.Controllers
{
    public class LojaController : Controller
    {
        private readonly ILogger<LojaController> _logger;

        public LojaController(ILogger<LojaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Loja()
        {
            return View();
        }
    }
}
