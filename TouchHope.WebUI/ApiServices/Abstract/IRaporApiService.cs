using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IRaporApiService
    {
        Task<List<RaporListModel>> GetirRaporlarByHastaHayvanId(int hastaHayvanId);
        Task EkleRapor(int hastaHayvanId, RaporAddModel model);
        Task SilRapor(int id);
        Task<RaporListModel> GetById(int id);
        Task GuncelleRapor(RaporUpdateModel model);
    }
}
