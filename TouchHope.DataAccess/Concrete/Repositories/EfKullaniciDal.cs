using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.DataAccess.Abstract;
using TouchHope.DataAccess.Concrete.Contexts;
using TouchHope.Entities.Concrete;

namespace TouchHope.DataAccess.Concrete.Repositories
{
    public class EfKullaniciDal : EfGenericDal<Kullanici>, IKullaniciDal
    {
        public async Task<List<Kullanici>> GetirGonulluErkekListesiBySehirId(string rolAd, int cinsiyetId, int sehirId)
        {
            using (var context = new TouchHopeContext())
            {
                var result = from roller in context.Roller
                             join kullaniciRoller in context.KullaniciRoller on roller.Id equals kullaniciRoller.RolId
                             join kullanicilar in context.Kullanicilar on kullaniciRoller.KullaniciId equals kullanicilar.Id
                             where roller.Ad == rolAd && kullanicilar.Cinsiyet.Id == cinsiyetId && kullanicilar.IlId == sehirId
                             select new Kullanici
                             {
                                 Id = kullanicilar.Id,
                                 KullaniciAd = kullanicilar.KullaniciAd,
                                 Ad = kullanicilar.Ad,
                                 Soyad = kullanicilar.Soyad,
                                 Email = kullanicilar.Email,
                                 TelefonNo = kullanicilar.TelefonNo,
                                 DogumTarih = kullanicilar.DogumTarih,
                                 CinsiyetId = kullanicilar.CinsiyetId,
                                 Cinsiyet = kullanicilar.Cinsiyet,
                                 IlId = kullanicilar.IlId,
                                 Il = kullanicilar.Il,
                                 Bildirimler = kullanicilar.Bildirimler,
                                 KullaniciRoller = kullanicilar.KullaniciRoller,
                                 HastaHayvanlar = kullanicilar.HastaHayvanlar
                             };
                return await result.ToListAsync();
            }
        }

        public async Task<int> GetirGonulluErkekSayisi(string rolAd, string cinsiyet)
        {
            using (var context = new TouchHopeContext())
            {
                var result = from roller in context.Roller
                             join kullaniciRoller in context.KullaniciRoller on roller.Id equals kullaniciRoller.RolId
                             join kullanicilar in context.Kullanicilar on kullaniciRoller.KullaniciId equals kullanicilar.Id
                             where roller.Ad == rolAd && kullanicilar.Cinsiyet.Ad == cinsiyet
                             select new Kullanici
                             {
                                 KullaniciAd = kullanicilar.KullaniciAd
                             };
                return await result.CountAsync();
            }
        }

        public async Task<List<Kullanici>> GetirGonulluKadinListesiBySehirId(string rolAd, int cinsiyetId, int sehirId)
        {
            using (var context = new TouchHopeContext())
            {
                var result = from roller in context.Roller
                             join kullaniciRoller in context.KullaniciRoller on roller.Id equals kullaniciRoller.RolId
                             join kullanicilar in context.Kullanicilar on kullaniciRoller.KullaniciId equals kullanicilar.Id
                             where roller.Ad == rolAd && kullanicilar.Cinsiyet.Id == cinsiyetId && kullanicilar.IlId == sehirId
                             select new Kullanici
                             {
                                 Id = kullanicilar.Id,
                                 KullaniciAd = kullanicilar.KullaniciAd,
                                 Ad = kullanicilar.Ad,
                                 Soyad = kullanicilar.Soyad,
                                 Email = kullanicilar.Email,
                                 TelefonNo = kullanicilar.TelefonNo,
                                 DogumTarih = kullanicilar.DogumTarih,
                                 CinsiyetId = kullanicilar.CinsiyetId,
                                 Cinsiyet = kullanicilar.Cinsiyet,
                                 IlId = kullanicilar.IlId,
                                 Il = kullanicilar.Il,
                                 Bildirimler = kullanicilar.Bildirimler,
                                 KullaniciRoller = kullanicilar.KullaniciRoller,
                                 HastaHayvanlar = kullanicilar.HastaHayvanlar
                             };
                return await result.ToListAsync();
            }
        }

        public async Task<int> GetirGonulluKadinSayisi(string rolAd, string cinsiyet)
        {
            using (var context = new TouchHopeContext())
            {
                var result = from roller in context.Roller
                             join kullaniciRoller in context.KullaniciRoller on roller.Id equals kullaniciRoller.RolId
                             join kullanicilar in context.Kullanicilar on kullaniciRoller.KullaniciId equals kullanicilar.Id
                             where roller.Ad == rolAd && kullanicilar.Cinsiyet.Ad == cinsiyet
                             select new Kullanici
                             {
                                 KullaniciAd = kullanicilar.KullaniciAd
                             };
                return await result.CountAsync();
            }
        }

        public async Task<List<Kullanici>> GetirGonulluListe(string rolAd)
        {
            using (var context = new TouchHopeContext())
            {
                var result = from roller in context.Roller
                             join kullaniciRoller in context.KullaniciRoller on roller.Id equals kullaniciRoller.RolId
                             join kullanicilar in context.Kullanicilar on kullaniciRoller.KullaniciId equals kullanicilar.Id
                             where roller.Ad == rolAd
                             select new Kullanici()
                             {
                                 Id = kullanicilar.Id,
                                 KullaniciAd = kullanicilar.KullaniciAd,
                                 Sifre = kullanicilar.Sifre,
                                 Ad = kullanicilar.Ad,
                                 Soyad = kullanicilar.Soyad,
                                 Email = kullanicilar.Email,
                                 TelefonNo = kullanicilar.TelefonNo,
                                 DogumTarih = kullanicilar.DogumTarih,
                                 CinsiyetId = kullanicilar.CinsiyetId,
                                 Cinsiyet = kullanicilar.Cinsiyet,
                                 IlId = kullanicilar.IlId,
                                 Il = kullanicilar.Il,
                                 Bildirimler = kullanicilar.Bildirimler,
                                 KullaniciRoller = kullanicilar.KullaniciRoller,
                                 HastaHayvanlar = kullanicilar.HastaHayvanlar
                             };
                return await result.ToListAsync();
            }
        }

        public async Task<List<Kullanici>> GetirGonulluListeByErkek(string rolAd, string cinsiyet)
        {
            using (var context = new TouchHopeContext())
            {
                var result = from roller in context.Roller
                             join kullaniciRoller in context.KullaniciRoller on roller.Id equals kullaniciRoller.RolId
                             join kullanicilar in context.Kullanicilar on kullaniciRoller.KullaniciId equals kullanicilar.Id
                             where roller.Ad == rolAd && kullanicilar.Cinsiyet.Ad==cinsiyet
                             select new Kullanici()
                             {
                                 Id = kullanicilar.Id,
                                 KullaniciAd = kullanicilar.KullaniciAd,
                                 Ad = kullanicilar.Ad,
                                 Soyad = kullanicilar.Soyad,
                                 Email = kullanicilar.Email,
                                 TelefonNo = kullanicilar.TelefonNo,
                                 DogumTarih = kullanicilar.DogumTarih,
                                 CinsiyetId = kullanicilar.CinsiyetId,
                                 Cinsiyet = kullanicilar.Cinsiyet,
                                 IlId = kullanicilar.IlId,
                                 Il = kullanicilar.Il,
                                 Bildirimler = kullanicilar.Bildirimler,
                                 KullaniciRoller = kullanicilar.KullaniciRoller,
                                 HastaHayvanlar = kullanicilar.HastaHayvanlar
                             };
                return await result.ToListAsync();
            }
        }

        public async Task<List<Kullanici>> GetirGonulluListeByKadin(string rolAd, string cinsiyet)
        {
            using (var context = new TouchHopeContext())
            {
                var result = from roller in context.Roller
                             join kullaniciRoller in context.KullaniciRoller on roller.Id equals kullaniciRoller.RolId
                             join kullanicilar in context.Kullanicilar on kullaniciRoller.KullaniciId equals kullanicilar.Id
                             where roller.Ad == rolAd && kullanicilar.Cinsiyet.Ad == cinsiyet
                             select new Kullanici()
                             {
                                 Id = kullanicilar.Id,
                                 KullaniciAd = kullanicilar.KullaniciAd,
                                 Ad = kullanicilar.Ad,
                                 Soyad = kullanicilar.Soyad,
                                 Email = kullanicilar.Email,
                                 TelefonNo = kullanicilar.TelefonNo,
                                 DogumTarih = kullanicilar.DogumTarih,
                                 CinsiyetId = kullanicilar.CinsiyetId,
                                 Cinsiyet = kullanicilar.Cinsiyet,
                                 IlId = kullanicilar.IlId,
                                 Il = kullanicilar.Il,
                                 Bildirimler = kullanicilar.Bildirimler,
                                 KullaniciRoller = kullanicilar.KullaniciRoller,
                                 HastaHayvanlar = kullanicilar.HastaHayvanlar
                             };
                return await result.ToListAsync();
            }
        }

        public async Task<List<Kullanici>> GetirGonulluListeBySehir(string rolAd, int ilId)
        {
            using (var context = new TouchHopeContext())
            {
                var result = from roller in context.Roller
                             join kullaniciRoller in context.KullaniciRoller on roller.Id equals kullaniciRoller.RolId
                             join kullanicilar in context.Kullanicilar on kullaniciRoller.KullaniciId equals kullanicilar.Id
                             where roller.Ad == rolAd && kullanicilar.IlId == ilId
                             select new Kullanici()
                             {
                                 Id = kullanicilar.Id,
                                 KullaniciAd = kullanicilar.KullaniciAd,
                                 Ad = kullanicilar.Ad,
                                 Soyad = kullanicilar.Soyad,
                                 Email = kullanicilar.Email,
                                 TelefonNo = kullanicilar.TelefonNo,
                                 DogumTarih = kullanicilar.DogumTarih,
                                 CinsiyetId = kullanicilar.CinsiyetId,
                                 Cinsiyet = kullanicilar.Cinsiyet,
                                 IlId = kullanicilar.IlId,
                                 Il = kullanicilar.Il,
                                 Bildirimler = kullanicilar.Bildirimler,
                                 KullaniciRoller = kullanicilar.KullaniciRoller,
                                 HastaHayvanlar = kullanicilar.HastaHayvanlar
                             };
                return await result.ToListAsync();
            }
        }

        public async Task<int> GetirGonulluSayisi(string rolAd)
        {
            using (var context = new TouchHopeContext())
            {
                var result = from roller in context.Roller
                             join kullaniciRoller in context.KullaniciRoller on roller.Id equals kullaniciRoller.RolId
                             join kullanicilar in context.Kullanicilar on kullaniciRoller.KullaniciId equals kullanicilar.Id
                             where roller.Ad == rolAd
                             select new Kullanici()
                             {
                                 KullaniciAd = kullanicilar.KullaniciAd
                             };
                return await result.CountAsync();
            }
        }

        public async Task<List<Rol>> GetirRoller(string kullaniciAd)
        {
            using (var context = new TouchHopeContext())
            {
                var result = from kullanici in context.Kullanicilar
                             join kullaniciRoller in context.KullaniciRoller on kullanici.Id equals kullaniciRoller.KullaniciId
                             join roller in context.Roller on kullaniciRoller.RolId equals roller.Id
                             where kullanici.KullaniciAd == kullaniciAd
                             select new Rol()
                             {
                                 Id = roller.Id,
                                 Ad = roller.Ad
                             };
                return await result.ToListAsync();
            }
        }
    }
}
