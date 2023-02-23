using BlogProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Business.Abstract
{
    public interface IIhbarService: IGenericService<Ihbar>
    {
        Task<Ihbar> FindByIdWithTablolar(int id);
        Task<List<Ihbar>> GetirHepsiTumTablolarla();
        Task<int> GetirIhbarSayisi();
    }
}
