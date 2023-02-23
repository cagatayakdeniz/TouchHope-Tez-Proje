using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Concrete
{
    public class RaporApiManager : IRaporApiService
    {
        private IHttpContextAccessor _httpContextAccessor;
        private HttpClient _httpClient;
        public RaporApiManager(IHttpContextAccessor httpContextAccessor, HttpClient httpClient)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/Rapor/");
        }

        public async Task EkleRapor(int hastaHayvanId, RaporAddModel model)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonData = JsonConvert.SerializeObject(model);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync($"RaporYaz/{hastaHayvanId}", stringContent);
        }

        public async Task<RaporListModel> GetById(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"{id}");

            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<RaporListModel>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<RaporListModel>> GetirRaporlarByHastaHayvanId(int hastaHayvanId)
        {
            var responseMessage = await _httpClient.GetAsync($"GetirRaporlarByHayvanId/{hastaHayvanId}");

            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<RaporListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task GuncelleRapor(RaporUpdateModel model)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonData = JsonConvert.SerializeObject(model);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"{model.Id}", stringContent);
        }

        public async Task SilRapor(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            await _httpClient.DeleteAsync($"{id}");
        }
    }
}
