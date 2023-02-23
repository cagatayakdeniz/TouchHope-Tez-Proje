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
    public class EfBildirimDal : EfGenericDal<Bildirim>, IBildirimDal
    {
        public async Task<List<Bildirim>> GetirOkunmamisBildirimListe(int kullaniciId)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Bildirimler.Where(x => x.KullaniciId == kullaniciId && !x.Durum).OrderByDescending(x=>x.Id).ToListAsync();
            }
        }

        public async Task<int> GetirOkunmamisBildirimSayisi(int kullaniciId)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Bildirimler.Where(x => x.KullaniciId == kullaniciId && !x.Durum).CountAsync();
            }
        }
    }
}
