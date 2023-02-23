using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Concrete
{
    public class IhbarApiManager : IIhbarApiService
    {
        private IHttpContextAccessor _httpContextAccessor;
        private HttpClient _httpClient;
        public IhbarApiManager(IHttpContextAccessor httpContextAccessor, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
            _httpClient.BaseAddress = new Uri("http://localhost:59932/api/ihbar/");
        }

        public async Task Ekle(IhbarAddModel model)
        {
            MultipartFormDataContent formData = new MultipartFormDataContent();
            if (model.Fotograf != null)
            {
                var stream = new MemoryStream();
                await model.Fotograf.CopyToAsync(stream);
                var bytes = stream.ToArray();

                ByteArrayContent byteContent = new ByteArrayContent(bytes);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue(model.Fotograf.ContentType);

                formData.Add(byteContent, nameof(IhbarAddModel.Fotograf), model.Fotograf.FileName);
            }

            formData.Add(new StringContent(model.Aciklama), nameof(IhbarAddModel.Aciklama));
            formData.Add(new StringContent(model.AcikAdres), nameof(IhbarAddModel.AcikAdres));
            formData.Add(new StringContent(model.AciliyetId.ToString()), nameof(IhbarAddModel.AciliyetId));
            formData.Add(new StringContent(model.IlId.ToString()), nameof(IhbarAddModel.IlId));
            formData.Add(new StringContent(model.TurId.ToString()), nameof(IhbarAddModel.TurId));

            await _httpClient.PostAsync("", formData);
        }

        public async Task<List<IhbarListModel>> GetirHepsi()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var responseMessage = await _httpClient.GetAsync("");

            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<IhbarListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task Onayla(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            await _httpClient.GetAsync($"IhbarOnayla/{id}");
        }

        public async Task Sil(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            await _httpClient.DeleteAsync($"{id}");
        }
    }
}
