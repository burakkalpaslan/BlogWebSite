using BlogSiteProject.Database;
using BlogSiteProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BlogSiteProject.Repository
{
    public class EFMakaleRepository : IMakaleRepository
    {
        private readonly BlogDbContext _context;

        public EFMakaleRepository(BlogDbContext context)
        {
            _context = context;
        }

        public IQueryable<Makale> Makaleler => _context.Makaleler;

        public bool DeleteMakale(int id)
        {
            _context.Makaleler.Remove(GetByID(id));
            return _context.SaveChanges() > 0;
        }

        public Makale GetByID(int id)
        {
            return _context.Makaleler.Find(id);
        }

        public IQueryable<Makale> GetByKullaniciID(int id)
        {
            IQueryable<Makale> makaleler = _context.Makaleler.Where(x => x.KullaniciID == id);
            return makaleler;
        }

        public bool InsertMakale(Makale makale)
        {
            _context.Makaleler.Add(makale);
            return _context.SaveChanges() > 0;
        }

        public bool UpdateMakale(Makale makale)
        {
            _context.Makaleler.Update(makale);
            return _context.SaveChanges() > 0;
        }
    }
}
