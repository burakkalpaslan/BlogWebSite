using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject.Models
{   
    public class Makale
    {
        public int MakaleID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }


        //Nav
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
