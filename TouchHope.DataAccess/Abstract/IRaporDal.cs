using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.DataAccess.Abstract
{
    public interface IRaporDal: IGenericDal<Rapor>
    {
        Task<int> GetirRaporSayisi();
        Task<int> GetirYazdigimRaporSayisi(int id);
        Task<List<Rapor>> GetirRaporlarByHayvanId(int hastaHayvanId);
    }
}
