using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IHastaHayvanApiService
    {
        Task<List<HastaHayvanListModel>> GetirHepsi();
        Task<List<HastaHayvanListModel>> GetirIyilesenHayvanlar();
        Task<List<HastaHayvanListModel>> GetirAktifGorevHastaHayvanById(int gonulluId);
        Task<List<HastaHayvanListModel>> GetirIyilestirilenHastaHayvanById(int gonulluId);
        Task TamamlandiOlarakIsaretle(int id);
    }
}
