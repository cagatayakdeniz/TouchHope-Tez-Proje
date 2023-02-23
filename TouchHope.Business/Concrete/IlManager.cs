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
    public class IlManager: GenericManager<Il>, IIlService
    {
        private IGenericDal<Il> _genericDal;
        private IIlDal _ilDal;

        public IlManager(IGenericDal<Il> genericDal, IIlDal ilDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _ilDal = ilDal;
        }
    }
}
