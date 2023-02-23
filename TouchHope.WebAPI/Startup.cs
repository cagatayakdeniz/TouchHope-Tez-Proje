using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using TouchHope.Business.Containers;
using System.Text;
using TouchHope.Business.StringInfos;
using FluentValidation.AspNetCore;
using TouchHope.DataAccess.Abstract;
using TouchHope.Business.Abstract;
using TouchHope.DataAccess.Concrete.Repositories;
using TouchHope.Business.Concrete;
using TouchHope.Entities.Dtos;
using FluentValidation;
using TouchHope.Business.ValidationRules;
using TouchHopeCore.Extensions;
using TouchHope.Core.DependencyResolvers;

namespace TouchHope.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            //services.AddDependencies();

            //services.AddTransient<IValidator<KullaniciSignInDto>, KullaniciSignInValidator>();
            //services.AddTransient<IValidator<KullaniciSignUpDto>, KullaniciSignUpValidator>();
            //services.AddTransient<IValidator<TurAddDto>, TurAddValidator>();
            //services.AddTransient<IValidator<TurUpdateDto>, TurUpdateValidator>();
            //services.AddTransient<IValidator<KullaniciUpdateDto>, KullaniciUpdateValidator>();

            services.AddControllers().AddNewtonsoftJson(opt =>
            {
                opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            }).AddFluentValidation();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.RequireHttpsMetadata = false;
                opt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidIssuer = JwtInfo.Issuer,
                    ValidAudience = JwtInfo.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtInfo.SecurityKey)),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });

            services.AddDependencyResolvers(new Core.Utilities.IoC.ICoreModule[]
            {
                new CoreModule(),
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
