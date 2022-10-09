using BlogSiteProject.Database;
using BlogSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject.Repository
{
    public class EFKullaniciRepository : IKullaniciRepository
    {
        private readonly BlogDbContext _context;

        public EFKullaniciRepository(BlogDbContext context)
        {
            _context = context;
        }
        public IQueryable<Kullanici> Kullanicilar => _context.Kullanicilar;
        public bool DeleteKullanici(int id)
        {
            _context.Kullanicilar.Remove(GetByID(id));
            return _context.SaveChanges() > 0;
        }

        public Kullanici GetByID(int id)
        {
            return _context.Kullanicilar.Find(id);
        }

        public bool InsertKullanici(Kullanici kullanici)
        {
            _context.Kullanicilar.Add(kullanici);
            return _context.SaveChanges()
                > 0;
        }

        public bool UpdateKullanici(Kullanici kullanici)
        {
            _context.Kullanicilar.Update(kullanici);
            return _context.SaveChanges() > 0;
        }
    }
}
