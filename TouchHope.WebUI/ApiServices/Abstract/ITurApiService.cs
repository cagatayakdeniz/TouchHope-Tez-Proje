using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface ITurApiService
    {
        Task<List<TurListModel>> GetirHepsi();
        Task Sil(int id);
        Task Ekle(TurAddModel turAddModel);
        Task Guncelle(TurUpdateModel turUpdateModel);
        Task<TurListModel> GetirById(int id);
    }
}
