using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;

namespace TouchHope.DataAccess.Abstract
{
    public interface IHastaHayvanDal: IGenericDal<HastaHayvan>
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
        Task<List<HastaHayvan>> GetirTamamlananTumTablolarla();
        Task<List<HastaHayvan>> GetirGorevliHastaHayvanlar(int gonulluId);
        Task<List<HastaHayvan>> GetirTamamlananHastaHayvanlarById(int gonulluId);
    }
}
