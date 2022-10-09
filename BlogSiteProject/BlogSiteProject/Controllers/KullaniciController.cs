using BlogSiteProject.Models;
using BlogSiteProject.Models.ViewModels;
using BlogSiteProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly IMakaleRepository _makaleRepository;

        public KullaniciController(IKullaniciRepository kullaniciRepository, IMakaleRepository makaleRepository)
        {
            _kullaniciRepository = kullaniciRepository;
            _makaleRepository = makaleRepository;
        }
        public IActionResult Index()
        {
            return View(_kullaniciRepository.Kullanicilar);
        }
        public IActionResult KullaniciDetaylari(int id)
        {
            KullaniciMakaleVM vm = new KullaniciMakaleVM();
            vm.Kullanici = _kullaniciRepository.GetByID(id);
            vm.Makaleler = _makaleRepository.GetByKullaniciID(id);

            return View(vm);
        }
        public IActionResult KullaniciDuzenle(int id)
        {
            return View(_kullaniciRepository.GetByID(id));
        }
        [HttpPost]
        public IActionResult KullaniciDuzenle(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                _kullaniciRepository.UpdateKullanici(kullanici);
            }
            return RedirectToAction("Index");
        }
        public IActionResult KullaniciSil(int id)
        {
            _kullaniciRepository.DeleteKullanici(id);
            return RedirectToAction("Index");
        }
        public IActionResult KullaniciEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KullaniciEkle(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                _kullaniciRepository.InsertKullanici(kullanici);
            }
            return RedirectToAction("Index");
        }
    }
}
