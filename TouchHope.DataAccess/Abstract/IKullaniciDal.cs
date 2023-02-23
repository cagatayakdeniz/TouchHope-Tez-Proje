using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.DataAccess.Abstract
{
    public interface IKullaniciDal: IGenericDal<Kullanici>
    {
        Task<List<Rol>> GetirRoller(string userName);
        Task<int> GetirGonulluSayisi(string rolAd);
        Task<List<Kullanici>> GetirGonulluListe(string rolAd);
        Task<List<Kullanici>> GetirGonulluListeByErkek(string rolAd, string cinsiyet);
        Task<List<Kullanici>> GetirGonulluListeByKadin(string rolAd, string cinsiyet);
        Task<int> GetirGonulluErkekSayisi(string rolAd, string cinsiyet);
        Task<int> GetirGonulluKadinSayisi(string rolAd, string cinsiyet);
        Task<List<Kullanici>> GetirGonulluListeBySehir(string rolAd, int ilId);
        Task<List<Kullanici>> GetirGonulluErkekListesiBySehirId(string rolAd, int cinsiyetId, int sehirId);
        Task<List<Kullanici>> GetirGonulluKadinListesiBySehirId(string rolAd, int cinsiyetId, int sehirId);
    }
}
