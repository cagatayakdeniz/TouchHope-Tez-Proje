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
    public class CinsiyetManager: GenericManager<Cinsiyet>, ICinsiyetService
    {
        private IGenericDal<Cinsiyet> _genericDal;
        private ICinsiyetDal _cinsiyetDal;

        public CinsiyetManager(IGenericDal<Cinsiyet> genericDal, ICinsiyetDal cinsiyetDal) :base(genericDal)
        {
            _genericDal = genericDal;
            _cinsiyetDal = cinsiyetDal;
        }
    }
}
