using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.DataAccess.Abstract;
using TouchHope.DataAccess.Concrete.Contexts;
using TouchHope.Entities.Concrete;

namespace TouchHope.DataAccess.Concrete.Repositories
{
    public class EfHastaHayvanDal : EfGenericDal<HastaHayvan>, IHastaHayvanDal
    {
        public async Task<int> AktifGorevHastaHayvanSayisi(int id)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Where(x => x.KullaniciId == id && x.Durum == false).CountAsync();
            }
        }
        // Çağatay Akdeniz //
        public async Task<int> IyilestirilenHastaHayvanSayisi(int id)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Where(x => x.KullaniciId == id && x.Durum == true).CountAsync();
            }
        }

        public async Task<int> GetirAktifIlgilenilenHayvanSayisi()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Where(x => x.KullaniciId != null && x.Durum == false).CountAsync();
            }
        }

        public async Task<int> GetirAtanmayıBekleyenHayvanSayisi()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Where(x => x.KullaniciId == null && x.Durum == false).CountAsync();
            }
        }

        public async Task<HastaHayvan> GetirByIdTumTablolarla(int id)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Include(x => x.Raporlar).Include(x => x.Kullanici)// Çağatay Akdeniz //
                    .Include(x => x.Il).Include(x => x.Tur).Include(x => x.Aciliyet)
                    .FirstOrDefaultAsync(x => x.Id == id);// Çağatay Akdeniz //
            }
        }

        public async Task<List<HastaHayvan>> GetirGorevliHastaHayvanlar(int gonulluId)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Include(x => x.Il).Include(x => x.Tur).Include(x => x.Aciliyet).Include(x=>x.Raporlar)
                                .Include(x=>x.Kullanici).Where(x => x.KullaniciId == gonulluId && !x.Durum).ToListAsync();
            }
        }

        public async Task<int> GetirHastaHayvanSayisi()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Where(x=>x.Durum == false).CountAsync();
            }
        }

        public async Task<int> GetirIyilesenHayvanSayisi()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Where(x => x.Durum == true).CountAsync();
            }// Çağatay Akdeniz //
        }

        public async Task<List<HastaHayvan>> GetirTamamlananTumTablolarla()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Include(x => x.Raporlar).Include(x => x.Il).Include(x => x.Tur).Include(x => x.Aciliyet)
                                .Include(x=>x.Kullanici).Where(x => x.Durum == true).ToListAsync();
            }
        }

        public async Task<List<HastaHayvan>> GetirTumTablolarla()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Include(x => x.Raporlar).Include(x=>x.Kullanici)
                                .Include(x => x.Il).Include(x => x.Tur).Include(x => x.Aciliyet)
                                .Where(x=>x.Durum == false).ToListAsync();
            }
        }

        public async Task<List<HastaHayvan>> GetirTamamlananHastaHayvanlarById(int gonulluId)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Include(x => x.Raporlar).Include(x => x.Kullanici).Include(x => x.Il).Include(x => x.Aciliyet)
                                .Include(x => x.Tur).Where(x => x.KullaniciId == gonulluId && x.Durum==true).ToListAsync();
            }
        }

        public async Task<List<HastaHayvan>> GetirTablolarlaList()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.HastaHayvanlar.Include(x => x.Il).Include(x => x.Tur).Include(x => x.Aciliyet)
                                .Where(x => x.Durum == false).ToListAsync();
            }
        }
    }
}
