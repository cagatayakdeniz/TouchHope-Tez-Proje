using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Entities.Dtos;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IGonulluApiService
    {
        Task<List<KullaniciListModel>> GetirHepsi();
        Task Sil(int id);
        Task<KullaniciListModel> GetirById(int id);
    }
}
