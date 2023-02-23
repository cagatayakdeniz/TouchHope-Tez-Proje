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
    public class AuthApiManager : IAuthApiService
    {
        private HttpClient _httpClient;
        private IHttpContextAccessor _httpContextAccessor;
        public AuthApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/auth/");
        }

        public KullaniciModel GetirAktifKullanici()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = _httpClient.GetAsync("AktifKullanici").Result;

            var aktifKullanici = JsonConvert.DeserializeObject<KullaniciModel>(responseMessage.Content.ReadAsStringAsync().Result);
            return aktifKullanici;
        }

        public async Task<bool> GirisYap(KullaniciSignInModel kullaniciSignInModel)
        {
            var jsonData = JsonConvert.SerializeObject(kullaniciSignInModel);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await _httpClient.PostAsync("SignIn", stringContent);

            if(responseMessage.IsSuccessStatusCode)
            {
                var token = JsonConvert.DeserializeObject<TokenModel>(await responseMessage.Content.ReadAsStringAsync());
                _httpContextAccessor.HttpContext.Session.SetString("token",token.Token);
                return true;
            }
            return false;
        }

        public async Task<KullaniciSignUpModel> KayitOl(KullaniciSignUpModel kullaniciSignUpModel)
        {
            var jsonData = JsonConvert.SerializeObject(kullaniciSignUpModel);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await _httpClient.PostAsync("KayitOl", stringContent);
        
            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<KullaniciSignUpModel>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task Guncelle(KullaniciUpdateModel kullaniciUpdateModel)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonData = JsonConvert.SerializeObject(kullaniciUpdateModel);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"{kullaniciUpdateModel.Id}", stringContent);
        }
    }
}
