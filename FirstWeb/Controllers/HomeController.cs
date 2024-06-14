using FirstWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FirstWeb.Data;

namespace FirstWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        
        public IActionResult Privacy()
        {
            return View();
        }
        
        
        public IActionResult PrintValue()
        {
            var bands = _context.Bands.ToList();
            if (bands == null)
            {
                return NotFound();
            }

            return View(bands);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}