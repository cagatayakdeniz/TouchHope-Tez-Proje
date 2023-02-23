using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TouchHope.WebUI.ApiServices.Abstract;

namespace TouchHope.WebUI.ApiServices.Concrete
{
    public class SayiApiManager : ISayiApiService
    {
        private HttpClient _httpClient;
        private IHttpContextAccessor _httpContextAccessor;
        public SayiApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/");
        }

        public async Task<int> IhbarSayisi()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync("ihbar/GetirIhbarSayisi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> HastaHayvanSayisi()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync("hastaHayvan/GetirHastaHayvanSayisi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> KaybolanHayvanSayisi()
        {
            var responseMessage = await _httpClient.GetAsync("kaybolanHayvan/GetirToplamSayi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> SahiplendirilecekHayvanSayisi()
        {
            var responseMessage = await _httpClient.GetAsync("sahiplendirilecekHayvan/GetirToplamSayi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> IyilesenHayvanSayisi()
        {
            var responseMessage = await _httpClient.GetAsync("hastaHayvan/GetirIyilesenHayvanSayisi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> AktifIlgilenilenHayvanSayisi()
        {
            var responseMessage = await _httpClient.GetAsync("hastaHayvan/GetirAktifIlgilenilenHayvanSayisi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> GonulluAtanmayanHayvanSayisi()
        {
            var responseMessage = await _httpClient.GetAsync("hastaHayvan/GetirAtanmayıBekleyenHayvanSayisi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> BildirimSayisi(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"bildirim/GetirBildirimSayisi/{id}");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> ToplamRaporSayisi()
        {
            var responseMessage = await _httpClient.GetAsync("rapor/GetirRaporSayisi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> GonulluSayisi()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"kullanici/GetirGonulluSayisi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> GonulluErkekSayisi()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"kullanici/GetirGonulluErkekSayisi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> GonulluKadinSayisi()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"kullanici/GetirGonulluKadinSayisi");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> AktifGorevHastaHayvanSayisi(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"hastaHayvan/GetirAktifGorevlendirildigimHayvanSayisi/{id}");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> IyilestirdigimHayvanSayisi(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"hastaHayvan/GetirIyilestirdigimHayvanSayisi/{id}");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }

        public async Task<int> YazdigimToplamRaporSayisi(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"rapor/GetirYazdigimRaporSayisi/{id}");
            var sayi = JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());

            return Convert.ToInt32(sayi);
        }
    }
}
