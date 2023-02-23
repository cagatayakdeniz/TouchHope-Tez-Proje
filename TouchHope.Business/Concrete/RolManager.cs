using BlogProject.Business.Abstract;
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
    public class RolManager: GenericManager<Rol>, IRolService
    {
        private IGenericDal<Rol> _genericDal;
        private IRolDal _rolDal;

        public RolManager(IGenericDal<Rol> genericDal, IRolDal rolDal)
            : base(genericDal)
        {
            _genericDal = genericDal;
            _rolDal = rolDal;
        }

        public async Task<Rol> GetirRolAd(string rolAd)
        {
            return await _rolDal.GetAsync(x => x.Ad == rolAd);
        }
    }
}
