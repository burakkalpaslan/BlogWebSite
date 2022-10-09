using BlogSiteProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject.Database.Mappings
{
    public class MakaleMapping : IEntityTypeConfiguration<Makale>
    {
        public void Configure(EntityTypeBuilder<Makale> builder)
        {
            builder.HasKey(s => new
            {
                s.MakaleID
            });

            builder.Property(e => e.MakaleID).UseIdentityColumn(1, 1);

            builder.Property(e => e.Title).IsUnicode(true).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Content).IsUnicode(true).HasMaxLength(1000).IsRequired();

            builder.HasOne<Kullanici>(x => x.Kullanici).WithMany(m => m.Makaleler).HasForeignKey(h => h.KullaniciID).HasConstraintName("FK_Makale_Kullanıcı");
        }

        



    }
}
