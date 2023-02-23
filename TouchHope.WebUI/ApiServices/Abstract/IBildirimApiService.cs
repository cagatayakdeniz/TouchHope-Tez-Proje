using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IBildirimApiService
    {
        Task Ekle(BildirimAddModel bildirimAddModel);
        Task<List<BildirimListModel>> GetirOkunmayanlar(int id);
        Task OkuBildirim(int id);
    }
}
