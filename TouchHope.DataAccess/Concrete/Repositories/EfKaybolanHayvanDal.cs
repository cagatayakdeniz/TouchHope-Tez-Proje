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
    public class EfKaybolanHayvanDal : EfGenericDal<KaybolanHayvan>, IKaybolanHayvanDal
    {
        public async Task<List<KaybolanHayvan>> GetirSehireGore(int ilId)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.KaybolanHayvanlar.Include(x=>x.Il).Include(x=>x.Tur).Where(x=>x.IlId == ilId).ToListAsync();
            }
        }

        public async Task<int> GetirToplamSayi()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.KaybolanHayvanlar.CountAsync();
            }
        }

        public async Task<List<KaybolanHayvan>> GetirTumTablolarla()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.KaybolanHayvanlar.Include(x => x.Il).Include(x => x.Tur).ToListAsync();
            }
        }
    }
}
