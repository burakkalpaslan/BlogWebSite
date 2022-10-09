using BlogSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject.Repository
{
    public class KullaniciRepository : IKullaniciRepository
    {
        public IQueryable<Kullanici> Kullanicilar => throw new NotImplementedException();

        public bool DeleteKullanici(int id)
        {
            throw new NotImplementedException();
        }

        public Kullanici GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool InsertKullanici(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }

        public bool UpdateKullanici(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }
    }
}
