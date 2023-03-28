using Microsoft.EntityFrameworkCore;

namespace PersonelAreasUygulama.Models
{
    public class Context : DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=PersonelAresUygulamaDB;Trusted_Connection=True;TrustServerCertificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Personel>().HasData(
            new Personel
            {
                PersonelId = 1,
                Ad = "William",
                Soyad = "Shakespeare",
                Maas = 50,
                DogumGunu = DateTime.Now,
                Email = "HotShakes@gmail.com",

            }, new Personel
            {
                PersonelId = 2,
                Ad = "Oguzhan",
                Soyad = "Yilmaz",
                Maas = 100,
                DogumGunu = DateTime.Now,
                Email = "ogzhnylmz95@gmail.com",

            }, new Personel
            {
                PersonelId = 3,
                Ad = "Cansu",
                Soyad = "Yilmaz",
                Maas = 150,
                DogumGunu = DateTime.Now,
                Email = "Cansu91@gmail.com",

            }) ;


            base.OnModelCreating(modelBuilder);
        }
    }
}
