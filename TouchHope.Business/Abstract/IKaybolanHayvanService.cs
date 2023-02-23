using BlogProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Business.Abstract
{
    public interface IKaybolanHayvanService: IGenericService<KaybolanHayvan>
    {
        Task<int> GetirToplamSayi();
        Task<List<KaybolanHayvan>> GetirTumTablolarla();
        Task<List<KaybolanHayvan>> GetirSehireGore(int ilId);
    }
}
