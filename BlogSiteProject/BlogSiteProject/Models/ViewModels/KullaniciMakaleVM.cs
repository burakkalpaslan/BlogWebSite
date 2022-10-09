using System.Collections.Generic;
using System.Linq;

namespace BlogSiteProject.Models.ViewModels
{
    public class KullaniciMakaleVM
    {
        public Kullanici Kullanici { get; set; }
        public IQueryable<Makale> Makaleler { get; set; }
    }
}
