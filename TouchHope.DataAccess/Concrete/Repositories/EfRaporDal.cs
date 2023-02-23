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
    public class EfRaporDal : EfGenericDal<Rapor>, IRaporDal
    {
        public async Task<List<Rapor>> GetirRaporlarByHayvanId(int hastaHayvanId)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Raporlar.Include(x=>x.HastaHayvan).Where(x=>x.HastaHayvanId==hastaHayvanId).ToListAsync();
            }// Çağatay Akdeniz //
        }

        public async Task<int> GetirRaporSayisi()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Raporlar.CountAsync();
            }
        }

        public async Task<int> GetirYazdigimRaporSayisi(int id)
        {
            using (var context = new TouchHopeContext())
            {
                var result = context.HastaHayvanlar.Include(x => x.Raporlar).Where(x => x.KullaniciId == id);

                return await result.SelectMany(x => x.Raporlar).CountAsync();
            }
        }
    }
}
