using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Concrete
{
    public class CinsiyetApiManager : ICinsiyetApiService
    {
        private HttpClient _httpClient;
        private IHttpContextAccessor _httpContextAccessor;
        public CinsiyetApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/cinsiyet/");
        }

        public async Task<CinsiyetListModel> GetirById(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CinsiyetListModel>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<CinsiyetListModel>> GetirHepsi()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CinsiyetListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
