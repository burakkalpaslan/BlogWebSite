using BlogSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject.Repository
{
    public interface IKullaniciRepository
    {
        IQueryable<Kullanici> Kullanicilar { get; } // set metodu olmayacak. Sadece okunabilir bir property ekledik.

        // Create (insert) işleminde kullanılacak metodu ekledikç

        bool InsertKullanici(Kullanici kullanici);

        bool UpdateKullanici(Kullanici kullanici);
        bool DeleteKullanici(int id);

        Kullanici GetByID(int id);
    }
}
