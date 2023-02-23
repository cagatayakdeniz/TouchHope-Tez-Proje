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
    public class KullaniciRolManager : GenericManager<KullaniciRol>, IKullaniciRolService
    {
        private IGenericDal<KullaniciRol> _genericDal;
        private IKullaniciRolDal _kullaniciRolDal;

        public KullaniciRolManager(IGenericDal<KullaniciRol> genericDal, IKullaniciRolDal kullaniciRolDal):base(genericDal)
        {
            _genericDal = genericDal;
            _kullaniciRolDal = kullaniciRolDal;
        }

    }
}
