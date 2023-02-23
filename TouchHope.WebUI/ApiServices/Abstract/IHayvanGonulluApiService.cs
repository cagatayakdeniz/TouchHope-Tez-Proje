using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IHayvanGonulluApiService
    {
        Task<List<HastaHayvanListModel>> GetirHepsi();
        Task<HastaHayvanListModel> GetirById(int id);
        Task Gorevlendir(int hayvanId, int gonulluId);
    }
}
