using BlogProject.Business.Concrete;
using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TouchHope.Business.Abstract;
using TouchHope.Business.ValidationRules;
using TouchHope.Core.Aspects.Autofac.Caching;
using TouchHope.Core.Aspects.Autofac.Logging;
using TouchHope.Core.Aspects.Autofac.Performance;
using TouchHope.Core.Aspects.Validation;
using TouchHope.Core.CrossCuttingConcerns.Logging.Log4net.Loggers;
using TouchHope.Core.CrossCuttingConcerns.Validation;
using TouchHope.DataAccess.Abstract;
using TouchHope.Entities.Concrete;

namespace TouchHope.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        [ValidationAspect(typeof(KullaniciSignUpValidator))]
        [CacheRemoveAspect("IKullaniciService.Get")]
        public async Task AddAsync(Kullanici kullanici)
        {
            //ValidationTool.Validate(new KullaniciSignUpValidator(), kullanici);
            await _kullaniciDal.AddAsync(kullanici);
        }

        [LogAspect(typeof(DatabaseLogger))]
        public async Task<List<Kullanici>> GetirGonulluErkekListesiBySehirId(string rolAd, int cinsiyetId, int sehirId)
        {
            return await _kullaniciDal.GetirGonulluErkekListesiBySehirId(rolAd, cinsiyetId, sehirId);
        }

        public async Task<int> GetirGonulluErkekSayisi(string rolAd, string cinsiyet)
        {
            return await _kullaniciDal.GetirGonulluErkekSayisi(rolAd, cinsiyet);
        }

        [LogAspect(typeof(DatabaseLogger))]
        public async Task<List<Kullanici>> GetirGonulluKadinListesiBySehirId(string rolAd, int cinsiyetId, int sehirId)
        {
            return await _kullaniciDal.GetirGonulluKadinListesiBySehirId(rolAd, cinsiyetId, sehirId);
        }

        public async Task<int> GetirGonulluKadinSayisi(string rolAd, string cinsiyet)
        {
            return await _kullaniciDal.GetirGonulluKadinSayisi(rolAd, cinsiyet);
        }

        [LogAspect(typeof(DatabaseLogger))]
        [CacheAspect(duration:10)]
        [PerformanceAspect(3)]
        public async Task<List<Kullanici>> GetirGonulluListe(string rolAd)
        {
            //Thread.Sleep(5000);
            return await _kullaniciDal.GetirGonulluListe(rolAd);
        }

        [Authorize(RoleInfo.Admin)]
        [LogAspect(typeof(DatabaseLogger))]
        public async Task<List<Kullanici>> GetirGonulluListeByErkek(string rolAd, string cinsiyet)
        {
            return await _kullaniciDal.GetirGonulluListeByErkek(rolAd, cinsiyet);
        }

        [LogAspect(typeof(DatabaseLogger))]
        public async Task<List<Kullanici>> GetirGonulluListeByKadin(string rolAd, string cinsiyet)
        {
            return await _kullaniciDal.GetirGonulluListeByKadin(rolAd, cinsiyet);
        }

        [LogAspect(typeof(DatabaseLogger))]
        public async Task<List<Kullanici>> GetirGonulluListeBySehir(string rolAd, int ilId)
        {
            return await _kullaniciDal.GetirGonulluListeBySehir(rolAd, ilId);
        }

        public async Task<int> GetirGonulluSayisi(string rolAd)
        {
            return await _kullaniciDal.GetirGonulluSayisi(rolAd);
        }

        public async Task<Kullanici> GetirKullaniciAd(string kullaniciAd)
        {
            return await _kullaniciDal.GetAsync(x => x.KullaniciAd == kullaniciAd);
        }

        public async Task<bool> GetirKullaniciByAd(string ad)
        {
            var kullanici = await _kullaniciDal.GetAsync(x => x.KullaniciAd == ad);

            if(kullanici==null)
            {
                return true;
            }

            return false;
        }

        public Task<List<Rol>> GetirRoller(string kullaniciAd)
        {
            return _kullaniciDal.GetirRoller(kullaniciAd);
        }

        public async Task<bool> GirisYap(string kullaniciAd, string sifre)
        {
            var kullanici = await _kullaniciDal.GetAsync(x => x.KullaniciAd == kullaniciAd);
            if(kullanici.Sifre==sifre)
            {
                return true;
            }
            return false;
        }
    }
}
