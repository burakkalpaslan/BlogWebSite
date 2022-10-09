using BlogSiteProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlogSiteProject.Repository
{
    public class MakaleRepository : IMakaleRepository
    {
        public IQueryable<Makale> Makaleler => throw new System.NotImplementedException();

        public bool DeleteMakale(int id)
        {
            throw new System.NotImplementedException();
        }

        public Makale GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Makale> GetByKullaniciID(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool InsertMakale(Makale makale)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateMakale(Makale makale)
        {
            throw new System.NotImplementedException();
        }
    }
}
