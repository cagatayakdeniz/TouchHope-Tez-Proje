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
    public class EfSahiplendirilecekHayvanDal : EfGenericDal<SahiplendirilecekHayvan>, ISahiplendirilecekHayvanDal
    {
        public async Task<List<SahiplendirilecekHayvan>> GetirSehireGore(int ilId)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.SahiplendirilecekHayvanlar.Include(x => x.Il).Include(x => x.Tur).Where(x=>x.IlId==ilId).ToListAsync();
            }
        }

        public async Task<int> GetirToplamSayi()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.SahiplendirilecekHayvanlar.CountAsync();
            }
        }

        public async Task<List<SahiplendirilecekHayvan>> GetirTumTablolarla()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.SahiplendirilecekHayvanlar.Include(x => x.Il).Include(x => x.Tur).ToListAsync();
            }
        }
    }
}
