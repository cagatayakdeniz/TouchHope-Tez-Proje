using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface ISayiApiService
    {
        Task<int> IhbarSayisi();
        Task<int> HastaHayvanSayisi();
        Task<int> KaybolanHayvanSayisi();
        Task<int> SahiplendirilecekHayvanSayisi();
        Task<int> IyilesenHayvanSayisi();
        Task<int> AktifIlgilenilenHayvanSayisi();
        Task<int> GonulluAtanmayanHayvanSayisi();
        Task<int> BildirimSayisi(int id);
        Task<int> ToplamRaporSayisi();
        Task<int> GonulluSayisi();
        Task<int> GonulluErkekSayisi();
        Task<int> GonulluKadinSayisi();
        Task<int> AktifGorevHastaHayvanSayisi(int id);
        Task<int> IyilestirdigimHayvanSayisi(int id);
        Task<int> YazdigimToplamRaporSayisi(int id);
    }
}
