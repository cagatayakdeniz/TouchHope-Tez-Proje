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
    public class KaybolanHayvanManager : GenericManager<KaybolanHayvan>, IKaybolanHayvanService
    {
        private IGenericDal<KaybolanHayvan> _genericDal;
        private IKaybolanHayvanDal _kaybolanHayvanDal;

        public KaybolanHayvanManager(IGenericDal<KaybolanHayvan> genericDal, IKaybolanHayvanDal kaybolanHayvanDal)
            : base(genericDal)
        {
            _genericDal = genericDal;
            _kaybolanHayvanDal = kaybolanHayvanDal;
        }

        public async Task<List<KaybolanHayvan>> GetirSehireGore(int ilId)
        {
            return await _kaybolanHayvanDal.GetirSehireGore(ilId);
        }

        public async Task<int> GetirToplamSayi()
        {
            return await _kaybolanHayvanDal.GetirToplamSayi();
        }

        public async Task<List<KaybolanHayvan>> GetirTumTablolarla()
        {
            return await _kaybolanHayvanDal.GetirTumTablolarla();
        }
    }
}
