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
    public class HastaHayvanManager : GenericManager<HastaHayvan>, IHastaHayvanService
    {
        private IGenericDal<HastaHayvan> _genericDal;
        private IHastaHayvanDal _hastaHayvanDal;

        public HastaHayvanManager(IGenericDal<HastaHayvan> genericDal, IHastaHayvanDal hastaHayvanDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _hastaHayvanDal = hastaHayvanDal;
        }

        public async Task<int> AktifGorevHastaHayvanSayisi(int id)
        {
            return await _hastaHayvanDal.AktifGorevHastaHayvanSayisi(id);
        }

        public async Task<List<HastaHayvan>> Ara(string aranacakKelime)
        {
            return await _hastaHayvanDal.GetAllAsync(x => x.Aciliyet.Tanim.Contains(aranacakKelime) || x.Il.Ad.Contains(aranacakKelime)
                                                            || x.Tur.Ad.Contains(aranacakKelime) || x.Aciklama.Contains(aranacakKelime));
        }

        public async Task<int> GetirAktifIlgilenilenHayvanSayisi()
        {
            return await _hastaHayvanDal.GetirAktifIlgilenilenHayvanSayisi();
        }

        public async Task<int> GetirAtanmayıBekleyenHayvanSayisi()
        {
            return await _hastaHayvanDal.GetirAtanmayıBekleyenHayvanSayisi();
        }

        public async Task<HastaHayvan> GetirByIdTumTablolarla(int id)
        {
            return await _hastaHayvanDal.GetirByIdTumTablolarla(id);
        }

        public async Task<List<HastaHayvan>> GetirGorevliHastaHayvanlar(int gonulluId)
        {
            return await _hastaHayvanDal.GetirGorevliHastaHayvanlar(gonulluId);
        }

        public async Task<int> GetirHastaHayvanSayisi()
        {
            return await _hastaHayvanDal.GetirHastaHayvanSayisi();
        }

        public async Task<int> GetirIyilesenHayvanSayisi()
        {
            return await _hastaHayvanDal.GetirIyilesenHayvanSayisi();
        }

        public async Task<List<HastaHayvan>> GetirTablolarlaList()
        {
            return await _hastaHayvanDal.GetirTablolarlaList();
        }

        public async Task<List<HastaHayvan>> GetirTamamlananHastaHayvanlarById(int gonulluId)
        {
            return await _hastaHayvanDal.GetirTamamlananHastaHayvanlarById(gonulluId);
        }

        public async Task<List<HastaHayvan>> GetirTamamlananTumTablolarla()
        {
            return await _hastaHayvanDal.GetirTamamlananTumTablolarla();
        }

        public async Task<List<HastaHayvan>> GetirTumTablolarla()
        {
            return await _hastaHayvanDal.GetirTumTablolarla();
        }

        public async Task<int> IyilestirilenHastaHayvanSayisi(int id)
        {
            return await _hastaHayvanDal.IyilestirilenHastaHayvanSayisi(id);
        }
    }
}
