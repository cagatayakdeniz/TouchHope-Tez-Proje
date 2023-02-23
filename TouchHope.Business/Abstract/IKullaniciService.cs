using BlogProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Business.Abstract
{
    public interface IKullaniciService
    {
        Task AddAsync(Kullanici kullanici);
        Task<List<Rol>> GetirRoller(string kullaniciAd);
        Task<Kullanici> GetirKullaniciAd(string kullaniciAd);
        Task<bool> GirisYap(string kullaniciAd, string sifre);
        Task<int> GetirGonulluSayisi(string rolAd);
        Task<List<Kullanici>> GetirGonulluListe(string rolAd);
        Task<List<Kullanici>> GetirGonulluListeByErkek(string rolAd, string cinsiyet);
        Task<List<Kullanici>> GetirGonulluListeByKadin(string rolAd, string cinsiyet);
        Task<int> GetirGonulluErkekSayisi(string rolAd, string cinsiyet);
        Task<int> GetirGonulluKadinSayisi(string rolAd, string cinsiyet);
        Task<List<Kullanici>> GetirGonulluListeBySehir(string rolAd, int ilId);
        Task<List<Kullanici>> GetirGonulluErkekListesiBySehirId(string rolAd, int cinsiyetId, int sehirId);
        Task<List<Kullanici>> GetirGonulluKadinListesiBySehirId(string rolAd, int cinsiyetId, int sehirId);
        Task<bool> GetirKullaniciByAd(string ad);
    }
}
