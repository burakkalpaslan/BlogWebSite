using BlogSiteProject.Models;
using BlogSiteProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly IMakaleRepository _makaleRepository;

        public HomeController(ILogger<HomeController> logger, IKullaniciRepository kullaniciRepository, IMakaleRepository makaleRepository)
        {
            _logger = logger;
            _kullaniciRepository = kullaniciRepository;
            _makaleRepository = makaleRepository;
        }

        public IActionResult Index()
        {
            IQueryable<Makale> makaleler = _makaleRepository.Makaleler.Include(x => x.Kullanici);
            return View(makaleler);
        }

        public IActionResult About()
        {
            return View();
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
