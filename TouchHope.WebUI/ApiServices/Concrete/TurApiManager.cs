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
    public class TurApiManager : ITurApiService
    {
        private IHttpContextAccessor _httpContextAccessor;
        private HttpClient _httpClient;
        public TurApiManager(IHttpContextAccessor httpContextAccessor, HttpClient httpClient)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/tur/");
        }

        public async Task Ekle(TurAddModel turAddModel)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonData = JsonConvert.SerializeObject(turAddModel);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync("", stringContent);
        }

        public async Task<TurListModel> GetirById(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"{id}");

            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TurListModel>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<TurListModel>> GetirHepsi()
        {
            var responseMessage = await _httpClient.GetAsync("");

            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<TurListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task Guncelle(TurUpdateModel turUpdateModel)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonData = JsonConvert.SerializeObject(turUpdateModel);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await _httpClient.PutAsync($"{turUpdateModel.Id}", stringContent);
        }

        public async Task Sil(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.DeleteAsync($"{id}");
        }
    }
}
