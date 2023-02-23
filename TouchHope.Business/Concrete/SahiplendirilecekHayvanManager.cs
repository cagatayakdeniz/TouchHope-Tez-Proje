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
    public class SahiplendirilecekHayvanManager : GenericManager<SahiplendirilecekHayvan>, ISahiplendirilecekHayvanService
    {
        private IGenericDal<SahiplendirilecekHayvan> _genericDal;
        private ISahiplendirilecekHayvanDal _sahiplendirilecekHayvanDal;

        public SahiplendirilecekHayvanManager(IGenericDal<SahiplendirilecekHayvan> genericDal, ISahiplendirilecekHayvanDal sahiplendirilecekHayvanDal)
            : base(genericDal)
        {
            _genericDal = genericDal;
            _sahiplendirilecekHayvanDal = sahiplendirilecekHayvanDal;
        }

        public async Task<List<SahiplendirilecekHayvan>> GetirSehireGore(int ilId)
        {
            return await _sahiplendirilecekHayvanDal.GetirSehireGore(ilId);
        }

        public async Task<int> GetirToplamSayi()
        {
            return await _sahiplendirilecekHayvanDal.GetirToplamSayi();
        }

        public async Task<List<SahiplendirilecekHayvan>> GetirTumTablolarla()
        {
            return await _sahiplendirilecekHayvanDal.GetirTumTablolarla();
        }
    }
}
