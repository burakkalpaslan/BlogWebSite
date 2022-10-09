using BlogSiteProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject.Database.Mappings
{
    public class KullaniciMapping : IEntityTypeConfiguration<Kullanici>
    {
        
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {


            builder.HasKey(s => new { s.ID });

            builder.Property(e => e.ID).UseIdentityColumn(1, 1);

            builder.Property(e => e.FirstName).IsUnicode(true).HasMaxLength(50).IsRequired();

            builder.Property(e => e.LastName).IsUnicode(true).HasMaxLength(50).IsRequired();



            //// Class
            //builder.HasOne<Kullanici>(s => s.ID)
            //    .WithMany(c => c.Students)
            //    .HasForeignKey(s => s.ClassNumber)
            //    .HasConstraintName("FK_Student_Class");



            //// ClassNumber
            //builder.Property(e => e.ClassNumber)
            //    .IsUnicode(true)
            //    .HasMaxLength(3).IsFixedLength().IsRequired();

            //// Class
            //builder.HasOne<Class>(s => s.Class)
            //    .WithMany(c => c.Students)
            //    .HasForeignKey(s => s.ClassNumber)
            //    .HasConstraintName("FK_Student_Class");

            // ÇOKA ÇOK İLİŞKİLERİ YAZMAMIZA GEREK YOK!!!
            // Courses
            //builder.HasMany<Course>(s => s.Courses)
            //    .WithMany(c => c.Students);
        }
    }
}
