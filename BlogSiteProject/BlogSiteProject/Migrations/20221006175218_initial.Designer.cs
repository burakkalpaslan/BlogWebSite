// <auto-generated />
using BlogSiteProject.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogSiteProject.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20221006175218_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogSiteProject.Models.Kullanici", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("BlogSiteProject.Models.Makale", b =>
                {
                    b.Property<int>("MakaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MakaleID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Makaleler");
                });

            modelBuilder.Entity("BlogSiteProject.Models.Makale", b =>
                {
                    b.HasOne("BlogSiteProject.Models.Kullanici", "Kullanici")
                        .WithMany("Makaleler")
                        .HasForeignKey("KullaniciID")
                        .HasConstraintName("FK_Makale_Kullanıcı")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("BlogSiteProject.Models.Kullanici", b =>
                {
                    b.Navigation("Makaleler");
                });
#pragma warning restore 612, 618
        }
    }
}
