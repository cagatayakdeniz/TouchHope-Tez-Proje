using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface ICinsiyetApiService
    {
        Task<List<CinsiyetListModel>> GetirHepsi();
        Task<CinsiyetListModel> GetirById(int id);
    }
}
