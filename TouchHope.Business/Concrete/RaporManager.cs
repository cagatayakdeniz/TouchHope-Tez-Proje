using BlogProject.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Business.Abstract;
using TouchHope.DataAccess.Abstract;
using TouchHope.Entities.Concrete;

namespace TouchHope.Business.Concrete
{
    public class RaporManager : GenericManager<Rapor>, IRaporService
    {
        private IGenericDal<Rapor> _genericDal;
        private IRaporDal _raporDal;

        public RaporManager(IGenericDal<Rapor> genericDal, IRaporDal raporDal)
            : base(genericDal)
        {
            _genericDal = genericDal;
            _raporDal = raporDal;
        }

        public async Task<List<Rapor>> GetirRaporlarByHayvanId(int hastaHayvanId)
        {
            return await _raporDal.GetirRaporlarByHayvanId(hastaHayvanId);
        }

        public async Task<int> GetirRaporSayisi()
        {
            return await _raporDal.GetirRaporSayisi();
        }

        public async Task<int> GetirYazdigimRaporSayisi(int id)
        {
            return await _raporDal.GetirYazdigimRaporSayisi(id);
        }
    }
}
