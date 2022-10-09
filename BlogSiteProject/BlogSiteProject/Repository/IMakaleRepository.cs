using BlogSiteProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlogSiteProject.Repository
{
    public interface IMakaleRepository
    {
        IQueryable<Makale> Makaleler { get; } 


        bool InsertMakale(Makale makale);

        bool UpdateMakale(Makale makale);
        bool DeleteMakale(int id);

        Makale GetByID(int id);

        IQueryable<Makale> GetByKullaniciID(int id);
    }
}
