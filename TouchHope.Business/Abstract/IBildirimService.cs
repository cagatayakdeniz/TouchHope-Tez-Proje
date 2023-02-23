using BlogProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Business.Abstract
{
    public interface IBildirimService: IGenericService<Bildirim>
    {
        Task<int> GetirOkunmamisBildirimSayisi(int kullaniciId);
        Task<List<Bildirim>> GetirOkunmamisBildirimListe(int kullaniciId);
    }
}
