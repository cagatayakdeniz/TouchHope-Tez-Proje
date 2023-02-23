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
    public class BildirimManager : GenericManager<Bildirim>, IBildirimService
    {
        private IGenericDal<Bildirim> _genericDal;
        private IBildirimDal _bildirimDal;

        public BildirimManager(IGenericDal<Bildirim> genericDal, IBildirimDal bildirimDal)
            : base(genericDal)
        {
            _genericDal = genericDal;
            _bildirimDal = bildirimDal;
        }

        public async Task<List<Bildirim>> GetirOkunmamisBildirimListe(int kullaniciId)
        {
            return await _bildirimDal.GetirOkunmamisBildirimListe(kullaniciId);
        }

        public async Task<int> GetirOkunmamisBildirimSayisi(int kullaniciId)
        {
            return await _bildirimDal.GetirOkunmamisBildirimSayisi(kullaniciId);
        }
    }
}
