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
    public class IhbarManager : GenericManager<Ihbar>, IIhbarService
    {
        private IGenericDal<Ihbar> _genericDal;
        private IIhbarDal _ihbarDal;

        public IhbarManager(IGenericDal<Ihbar> genericDal, IIhbarDal ihbarDal)
            : base(genericDal)
        {
            _genericDal = genericDal;
            _ihbarDal = ihbarDal;
        }

        public async Task<Ihbar> FindByIdWithTablolar(int id)
        {
            return await _ihbarDal.FindByIdWithTablolar(id);
        }

        public async Task<List<Ihbar>> GetirHepsiTumTablolarla()
        {
            return await _ihbarDal.GetirHepsiTumTablolarla();
        }

        public async Task<int> GetirIhbarSayisi()
        {
            return await _ihbarDal.GetirIhbarSayisi();
        }
    }
}
