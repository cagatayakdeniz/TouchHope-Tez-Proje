using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IResimApiService
    {
        Task<string> GetirIhbarResimById(int id);
        Task<string> GetirHastaHayvanResimById(int id);
        Task<string> GetirKaybolanHayvanResimById(int id);
        Task<string> GetirSahiplendirilecekHayvanResimById(int id);
    }
}
