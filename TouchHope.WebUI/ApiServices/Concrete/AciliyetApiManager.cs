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
    public class AciliyetApiManager : IAciliyetApiService
    {
        private IHttpContextAccessor _httpContextAccessor;
        private HttpClient _httpClient;
        public AciliyetApiManager(IHttpContextAccessor httpContextAccessor, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/aciliyet/");
        }

        public async Task<List<AciliyetListModel>> GetirHepsi()
        {
            var responseMessage = await _httpClient.GetAsync("");

            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<AciliyetListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
