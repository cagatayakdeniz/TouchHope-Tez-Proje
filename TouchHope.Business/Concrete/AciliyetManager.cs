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
    public class AciliyetManager : GenericManager<Aciliyet>, IAciliyetService
    {
        private IGenericDal<Aciliyet> _genericDal;
        private IAciliyetDal _aciliyetDal;

        public AciliyetManager(IGenericDal<Aciliyet> genericDal, IAciliyetDal aciliyetDal)
            : base(genericDal)
        {
            _genericDal = genericDal;
            _aciliyetDal = aciliyetDal;
        }
    }
}
