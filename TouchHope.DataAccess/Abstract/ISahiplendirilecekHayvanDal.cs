using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.DataAccess.Abstract
{
    public interface ISahiplendirilecekHayvanDal: IGenericDal<SahiplendirilecekHayvan>
    {
        Task<int> GetirToplamSayi();
        Task<List<SahiplendirilecekHayvan>> GetirTumTablolarla();
        Task<List<SahiplendirilecekHayvan>> GetirSehireGore(int ilId);
    }
}
