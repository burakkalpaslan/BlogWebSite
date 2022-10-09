using BlogSiteProject.Database.Mappings;
using BlogSiteProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject.Database
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MakaleMapping())
                .ApplyConfiguration(new KullaniciMapping());
        }

        public DbSet<Makale> Makaleler{ get; set; }
        public DbSet<Kullanici> Kullanicilar{ get; set; }
    }
}
