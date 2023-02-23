using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Concrete
{
    public class HastaHayvanApiManager: IHastaHayvanApiService
    {
        private IHttpContextAccessor _httpContextAccessor;
        private HttpClient _httpClient;
        public HastaHayvanApiManager(IHttpContextAccessor httpContextAccessor, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/hastaHayvan/");
        }

        public async Task<List<HastaHayvanListModel>> GetirAktifGorevHastaHayvanById(int gonulluId)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"GetirGorevliHastaHayvanlar/{gonulluId}");

            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<HastaHayvanListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<HastaHayvanListModel>> GetirHepsi()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync("GetirHastaHayvanlar");

            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<HastaHayvanListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<HastaHayvanListModel>> GetirIyilesenHayvanlar()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync("GetirTamamlananHayvanlar");

            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<HastaHayvanListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<HastaHayvanListModel>> GetirIyilestirilenHastaHayvanById(int gonulluId)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync($"GetirTamamlananHastaHayvanlar/{gonulluId}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<HastaHayvanListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task TamamlandiOlarakIsaretle(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            await _httpClient.GetAsync($"TamamlandiOlarakIsaretle/{id}");
        }
    }
}
