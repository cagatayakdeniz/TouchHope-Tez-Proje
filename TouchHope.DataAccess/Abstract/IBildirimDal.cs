using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.DataAccess.Abstract
{
    public interface IBildirimDal: IGenericDal<Bildirim>
    {
        Task<int> GetirOkunmamisBildirimSayisi(int kullaniciId);
        Task<List<Bildirim>> GetirOkunmamisBildirimListe(int kullaniciId);
    }
}
