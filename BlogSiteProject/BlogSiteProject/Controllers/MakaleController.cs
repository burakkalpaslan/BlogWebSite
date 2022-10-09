using BlogSiteProject.Database;
using BlogSiteProject.Models;
using BlogSiteProject.Models.ViewModels;
using BlogSiteProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogSiteProject.Controllers
{
    public class MakaleController : Controller
    {
        private readonly IMakaleRepository _repo;
        private readonly IKullaniciRepository _kullaniciRepository;

        public MakaleController(IMakaleRepository makaleRepository, IKullaniciRepository kullaniciRepository)
        {
            _repo = makaleRepository;
            _kullaniciRepository = kullaniciRepository;
        }

        public IActionResult Index()
        {
            return View(_repo.Makaleler.Include(x=>x.Kullanici));
        }

        [HttpGet]
        public IActionResult MakaleEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakaleEkle(Makale makale)
        {
            if (ModelState.IsValid)
            {
                _repo.InsertMakale(makale);
            }
            return RedirectToAction("Index");
        }
        public IActionResult MakaleDetaylari(int id)
        {
            KullaniciMakaleVM vm = new KullaniciMakaleVM();
            vm.Kullanici = _kullaniciRepository.GetByID(id);
            vm.Makaleler = _repo.GetByKullaniciID(id);

            return View(vm);
        }

        public IActionResult MakaleSil(int id)
        {
            _repo.DeleteMakale(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MakaleDuzenle(int id)
        {
            Makale duzenlenecekMakale = _repo.GetByID(id);
            return View(duzenlenecekMakale);
        }

        [HttpPost]
        public IActionResult MakaleDuzenle(Makale makale)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateMakale(makale);
            }
            return View(makale);
        }

    }
}
