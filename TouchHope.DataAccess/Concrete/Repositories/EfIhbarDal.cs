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
    public class EfIhbarDal : EfGenericDal<Ihbar>, IIhbarDal
    {
        public async Task<Ihbar> FindByIdWithTablolar(int id)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Ihbarlar.Include(x => x.Aciliyet).Include(x => x.Il).Include(x => x.Tur).FirstOrDefaultAsync(x => x.Id == id);
            }
        }

        public async Task<List<Ihbar>> GetirHepsiTumTablolarla()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Ihbarlar.Include(x => x.Il).Include(x => x.Aciliyet).Include(x => x.Tur).ToListAsync();
            }
        }

        public async Task<int> GetirIhbarSayisi()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Ihbarlar.CountAsync();
            }
        }
    }
}
