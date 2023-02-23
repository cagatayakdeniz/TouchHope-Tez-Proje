using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.DataAccess.Abstract
{
    public interface IKaybolanHayvanDal: IGenericDal<KaybolanHayvan>
    {
        Task<int> GetirToplamSayi();
        Task<List<KaybolanHayvan>> GetirTumTablolarla();
        Task<List<KaybolanHayvan>> GetirSehireGore(int ilId);
    }
}
