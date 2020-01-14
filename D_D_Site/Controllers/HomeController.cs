using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using D_D_Site.Models;

namespace D_D_Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly D_DContext _context;

        public HomeController(D_DContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List <Roles> roles = _context.Roles.ToList();

            return View(roles);
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
