using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TouchHope.WebUI.ApiServices.Abstract;

namespace TouchHope.WebUI.ApiServices.Concrete
{
    public class ResimApiManager : IResimApiService
    {
        private HttpClient _httpClient;
        public ResimApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/resim/");
        }

        public async Task<string> GetirIhbarResimById(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"GetIhbarResimById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var bytes = await responseMessage.Content.ReadAsByteArrayAsync();
                return $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";
            }
            return null;
        }

        public async Task<string> GetirHastaHayvanResimById(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"GetHastaHayvanResimById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var bytes = await responseMessage.Content.ReadAsByteArrayAsync();
                return $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";
            }
            return null;
        }

        public async Task<string> GetirKaybolanHayvanResimById(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"GetKaybolanHayvanResimById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var bytes = await responseMessage.Content.ReadAsByteArrayAsync();
                return $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";
            }
            return null;
        }

        public async Task<string> GetirSahiplendirilecekHayvanResimById(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"GetSahiplendirilecekHayvanResimById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var bytes = await responseMessage.Content.ReadAsByteArrayAsync();
                return $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";
            }
            return null;
        }
    }
}
