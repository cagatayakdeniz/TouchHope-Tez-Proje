using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.DataAccess.Concrete.Contexts
{
    public class TouchHopeContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TouchHopeDB;integrated security=true");
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<KullaniciRol> KullaniciRoller { get; set; }
        public DbSet<Bildirim> Bildirimler { get; set; }
        public DbSet<HastaHayvan> HastaHayvanlar { get; set; }
        public DbSet<Rapor> Raporlar { get; set; }
        public DbSet<Aciliyet> Aciliyetler { get; set; }
        public DbSet<Il> Iller { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Ihbar> Ihbarlar { get; set; }
        public DbSet<Cinsiyet> Cinsiyetler { get; set; }
        public DbSet<SahiplendirilecekHayvan> SahiplendirilecekHayvanlar { get; set; }
        public DbSet<KaybolanHayvan> KaybolanHayvanlar { get; set; }
    }
}
// Çağatay Akdeniz //