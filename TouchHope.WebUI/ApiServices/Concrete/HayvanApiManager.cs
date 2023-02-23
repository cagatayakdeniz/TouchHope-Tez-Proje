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
    public class HayvanApiManager: IHayvanApiService
    {
        private IHttpContextAccessor _httpContextAccessor;
        private HttpClient _httpClient;
        public HayvanApiManager(IHttpContextAccessor httpContextAccessor, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task EkleKayip(KayipAddModel model)
        {
            MultipartFormDataContent formData = new MultipartFormDataContent();
            if (model.Fotograf != null)
            {
                var stream = new MemoryStream();
                await model.Fotograf.CopyToAsync(stream);
                var bytes = stream.ToArray();

                ByteArrayContent byteContent = new ByteArrayContent(bytes);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue(model.Fotograf.ContentType);

                formData.Add(byteContent, nameof(KayipAddModel.Fotograf), model.Fotograf.FileName);
            }

            formData.Add(new StringContent(model.Aciklama), nameof(KayipAddModel.Aciklama));
            formData.Add(new StringContent(model.IlId.ToString()), nameof(KayipAddModel.IlId));
            formData.Add(new StringContent(model.TurId.ToString()), nameof(KayipAddModel.TurId));
            formData.Add(new StringContent(model.TelefonNo), nameof(KayipAddModel.TelefonNo));

            await _httpClient.PostAsync("http://localhost:59932/api/kaybolanHayvan", formData);
        }

        public async Task EkleSahiplendir(SahiplendirAddModel model)
        {
            MultipartFormDataContent formData = new MultipartFormDataContent();
            if (model.Fotograf != null)
            {
                var stream = new MemoryStream();
                await model.Fotograf.CopyToAsync(stream);
                var bytes = stream.ToArray();

                ByteArrayContent byteContent = new ByteArrayContent(bytes);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue(model.Fotograf.ContentType);

                formData.Add(byteContent, nameof(SahiplendirAddModel.Fotograf), model.Fotograf.FileName);
            }

            formData.Add(new StringContent(model.Ad), nameof(SahiplendirAddModel.Ad));
            formData.Add(new StringContent(model.Yas), nameof(SahiplendirAddModel.Yas));
            formData.Add(new StringContent(model.Aciklama), nameof(SahiplendirAddModel.Aciklama));
            formData.Add(new StringContent(model.IlId.ToString()), nameof(SahiplendirAddModel.IlId));
            formData.Add(new StringContent(model.TurId.ToString()), nameof(SahiplendirAddModel.TurId));
            formData.Add(new StringContent(model.TelefonNo), nameof(SahiplendirAddModel.TelefonNo));

            await _httpClient.PostAsync("http://localhost:59932/api/sahiplendirilecekHayvan", formData);
        }

        public async Task<List<KaybolanHayvanListModel>> GetirHepsiKaybolanHayvanlar()
        {
            var responseMessage = await _httpClient.GetAsync("http://localhost:59932/api/kaybolanHayvan/");

            if(responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<KaybolanHayvanListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<SahiplendirilecekHayvanListModel>> GetirHepsiSahiplendirilecekHayvanlar()
        {
            var responseMessage = await _httpClient.GetAsync("http://localhost:59932/api/sahiplendirilecekHayvan/");

            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<SahiplendirilecekHayvanListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<KaybolanHayvanListModel>> GetirSehireGoreKaybolanHayvanlar(int ilId)
        {
            var responseMessage = await _httpClient.GetAsync($"http://localhost:59932/api/kaybolanHayvan/GetirSehireGore/{ilId}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<KaybolanHayvanListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<SahiplendirilecekHayvanListModel>> GetirSehireGoreSahiplendirilecekHayvanlar(int ilId)
        {
            var responseMessage = await _httpClient.GetAsync($"http://localhost:59932/api/sahiplendirilecekHayvan/GetirSehireGore/{ilId}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<SahiplendirilecekHayvanListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task SilKaybolan(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            await _httpClient.DeleteAsync($"http://localhost:59932/api/kaybolanHayvan/{id}");
        }

        public async Task SilSahiplendirilecek(int id)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            await _httpClient.DeleteAsync($"http://localhost:59932/api/sahiplendirilecekHayvan/{id}");
        }
    }
}
