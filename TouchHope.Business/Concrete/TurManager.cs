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
    public class TurManager : GenericManager<Tur>, ITurService
    {
        private IGenericDal<Tur> _genericDal;
        private ITurDal _turDal;

        public TurManager(IGenericDal<Tur> genericDal, ITurDal turDal)
            : base(genericDal)
        {
            _genericDal = genericDal;
            _turDal = turDal;
        }
    }
}
