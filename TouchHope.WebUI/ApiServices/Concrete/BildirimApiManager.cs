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
    public class BildirimApiManager : IBildirimApiService
    {
        private HttpClient _httpClient;
        private IHttpContextAccessor _httpContextAccessor;
        public BildirimApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/bildirim/");
        }

        public async Task Ekle(BildirimAddModel bildirimAddModel)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonData = JsonConvert.SerializeObject(bildirimAddModel);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync("", stringContent);
        }

        public async Task<List<BildirimListModel>> GetirOkunmayanlar(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"GetirBildirimlerListe/{id}");

            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<BildirimListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task OkuBildirim(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            await _httpClient.GetAsync($"OkuBildirim/{id}");
        }
    }
}
