using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.DataAccess.Abstract
{
    public interface IIhbarDal: IGenericDal<Ihbar>
    {
        Task<Ihbar> FindByIdWithTablolar(int id);
        Task<List<Ihbar>> GetirHepsiTumTablolarla();
        Task<int> GetirIhbarSayisi();
    }
}
