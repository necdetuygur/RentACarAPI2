using Microsoft.EntityFrameworkCore;
using RentACar2.Core.Models;
using RentACar2.Data.Configurations;
using RentACar2.Data.Seeds;

namespace RentACar2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Araba> Arabas { get; set; }
        public DbSet<Alici> Alicis { get; set; }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Kiralama> Kiralamas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArabaConfiguration());
            modelBuilder.ApplyConfiguration(new ArabaSeed());

            modelBuilder.ApplyConfiguration(new AliciConfiguration());
            modelBuilder.ApplyConfiguration(new AliciSeed());

            modelBuilder.ApplyConfiguration(new FirmaConfiguration());
            modelBuilder.ApplyConfiguration(new FirmaSeed());

            modelBuilder.ApplyConfiguration(new KiralamaConfiguration());
            modelBuilder.ApplyConfiguration(new KiralamaSeed());
        }
    }
}
