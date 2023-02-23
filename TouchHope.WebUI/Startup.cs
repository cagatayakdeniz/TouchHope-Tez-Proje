using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Business.Abstract;
using TouchHope.Business.Concrete;
using TouchHope.Business.Containers;
using TouchHope.DataAccess.Abstract;
using TouchHope.DataAccess.Concrete.Repositories;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.ApiServices.Concrete;

namespace TouchHope.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddDependencies();
            services.AddHttpContextAccessor();
            services.AddHttpClient<IAciliyetApiService, AciliyetApiManager>();
            services.AddHttpClient<IRaporApiService, RaporApiManager>();
            services.AddHttpClient<IResimApiService, ResimApiManager>();
            services.AddHttpClient<IHayvanGonulluApiService, HayvanGonulluApiManager>();
            services.AddHttpClient<IIhbarApiService, IhbarApiManager>();
            services.AddHttpClient<IHayvanApiService, HayvanApiManager>();
            services.AddHttpClient<IHastaHayvanApiService, HastaHayvanApiManager>();
            services.AddHttpClient<IAuthApiService, AuthApiManager>();
            services.AddHttpClient<ICinsiyetApiService, CinsiyetApiManager>();
            services.AddHttpClient<IIlApiService, IlApiManager>();
            services.AddHttpClient<ISayiApiService, SayiApiManager>();
            services.AddHttpClient<ITurApiService, TurApiManager>();
            services.AddHttpClient<IGonulluApiService, GonulluApiManager>();
            services.AddHttpClient<IBildirimApiService, BildirimApiManager>();
            services.AddSession();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSession();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area}/{Controller=AnaSayfa}/{Action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{Controller=Home}/{Action=Index}/{id?}"
                );
            });
        }
    }
}
