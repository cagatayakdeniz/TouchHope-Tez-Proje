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
    public class IlApiManager : IIlApiService
    {
        private HttpClient _httpClient;
        private IHttpContextAccessor _httpContextAccessor;
        public IlApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/il/");
        }

        public async Task<IlListModel> GetirById(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<IlListModel>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<IlListModel>> GetirHepsi()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<IlListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
