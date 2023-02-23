using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IIlApiService
    {
        Task<List<IlListModel>> GetirHepsi();
        Task<IlListModel> GetirById(int id);
    }
}
