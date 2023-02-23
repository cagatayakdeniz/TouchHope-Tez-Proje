using BlogProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.Business.Abstract
{
    public interface IHastaHayvanService: IGenericService<HastaHayvan>
    {
        Task<int> GetirHastaHayvanSayisi();
        Task<int> GetirIyilesenHayvanSayisi();
        Task<int> GetirAktifIlgilenilenHayvanSayisi();
        Task<int> GetirAtanmayıBekleyenHayvanSayisi();
        Task<int> AktifGorevHastaHayvanSayisi(int id);
        Task<int> IyilestirilenHastaHayvanSayisi(int id);
        Task<List<HastaHayvan>> GetirTumTablolarla();
        Task<List<HastaHayvan>> GetirTablolarlaList();
        Task<HastaHayvan> GetirByIdTumTablolarla(int id);
        Task<List<HastaHayvan>> Ara(string aranacakKelime);
        Task<List<HastaHayvan>> GetirTamamlananTumTablolarla();
        Task<List<HastaHayvan>> GetirGorevliHastaHayvanlar(int gonulluId);
        Task<List<HastaHayvan>> GetirTamamlananHastaHayvanlarById(int gonulluId);
    }
}
