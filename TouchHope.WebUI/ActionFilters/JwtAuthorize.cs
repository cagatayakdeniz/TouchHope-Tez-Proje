using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TouchHope.Entities.Dtos;

namespace TouchHope.WebUI.ActionFilters
{
    public class JwtAuthorize : ActionFilterAttribute
    {
        public string Roller { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var token = context.HttpContext.Session.GetString("token");

            if (string.IsNullOrWhiteSpace(token))
            {
                context.Result = new RedirectToActionResult("SignIn", "Auth", new { area = "" });
            }
            else
            {
                using var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var responseMessage = httpClient.GetAsync("http://localhost:59932/api/Auth/AktifKullanici").Result;

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var aktifKullanici = JsonConvert.DeserializeObject<KullaniciDto>(responseMessage.Content.ReadAsStringAsync().Result);
                   
                    if (!string.IsNullOrEmpty(Roller))
                    {
                        bool accessStatus = false;
                        if (Roller.Contains(","))
                        {
                            var acceptedUser = Roller.Split(',');
                            foreach (var role in acceptedUser)
                            {
                                if (aktifKullanici.Roles.Contains(role))
                                {
                                    accessStatus = true;
                                }
                            }
                        }
                        else
                        {
                            if (aktifKullanici.Roles.Contains(Roller))
                            {
                                accessStatus = true;
                            }
                        }
                        if (!accessStatus)
                        {
                            context.Result = new RedirectToActionResult("AccessDenied", "Auth", new { area = "" });
                        }
                    }
                }
                else if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
                {
                    context.HttpContext.Session.Remove("token");
                    context.Result = new RedirectToActionResult("SignIn", "Auth", new { area = "" });
                }
                else
                {
                    var statusCode = responseMessage.StatusCode.ToString();
                    context.HttpContext.Session.Remove("token");
                    context.Result = new RedirectToActionResult("SignIn", "Auth", new { code = statusCode });
                }
            }
        }
    }
}

