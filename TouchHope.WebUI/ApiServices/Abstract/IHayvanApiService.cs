using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IHayvanApiService
    {
        Task<List<KaybolanHayvanListModel>> GetirHepsiKaybolanHayvanlar();
        Task<List<SahiplendirilecekHayvanListModel>> GetirHepsiSahiplendirilecekHayvanlar();
        Task<List<KaybolanHayvanListModel>> GetirSehireGoreKaybolanHayvanlar(int ilId);
        Task<List<SahiplendirilecekHayvanListModel>> GetirSehireGoreSahiplendirilecekHayvanlar(int ilId);
        Task SilKaybolan(int id);
        Task SilSahiplendirilecek(int id);
        Task EkleKayip(KayipAddModel model);
        Task EkleSahiplendir(SahiplendirAddModel model);
    }
}
