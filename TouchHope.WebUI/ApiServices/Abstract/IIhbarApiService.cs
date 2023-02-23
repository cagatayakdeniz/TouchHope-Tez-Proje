using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IIhbarApiService
    {
        Task<List<IhbarListModel>> GetirHepsi();
        Task Sil(int id);
        Task Onayla(int id);
        Task Ekle(IhbarAddModel model);
    }
}
