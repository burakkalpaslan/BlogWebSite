using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject.Models
{
    public class Kullanici
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        //Navigation Property

        public List<Makale> Makaleler { get; set; }
    }
}
