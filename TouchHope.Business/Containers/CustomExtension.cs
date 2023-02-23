
using BlogProject.Business.Abstract;
using BlogProject.Business.Concrete;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Business.Abstract;
using TouchHope.Business.Concrete;
using TouchHope.Business.Utilities.Jwt;
using TouchHope.Business.ValidationRules;
using TouchHope.DataAccess.Abstract;
using TouchHope.DataAccess.Concrete.Repositories;
using TouchHope.Entities.Dtos;

namespace TouchHope.Business.Containers
{
    public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericDal<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<ICinsiyetService, CinsiyetManager>();
            services.AddScoped<IIlService, IlManager>();
            services.AddScoped<IAciliyetService, AciliyetManager>();
            services.AddScoped<IBildirimService, BildirimManager>();
            services.AddScoped<IHastaHayvanService, HastaHayvanManager>();
            services.AddScoped<IIhbarService, IhbarManager>();
            services.AddScoped<IKaybolanHayvanService, KaybolanHayvanManager>();
            services.AddScoped<IKullaniciService, KullaniciManager>();
            services.AddScoped<IRaporService, RaporManager>();
            services.AddScoped<ISahiplendirilecekHayvanService, SahiplendirilecekHayvanManager>();
            services.AddScoped<ITurService, TurManager>();
            services.AddScoped<IRolService, RolManager>();
            services.AddScoped<IKullaniciRolService, KullaniciRolManager>();
            services.AddScoped<IDosyaService, DosyaManager>();

            services.AddScoped<ICinsiyetDal, EfCinsiyetDal>();
            services.AddScoped<IIlDal, EfIlDal>();
            services.AddScoped<IAciliyetDal, EfAciliyetDal>();
            services.AddScoped<IBildirimDal, EfBildirimDal>();
            services.AddScoped<IHastaHayvanDal, EfHastaHayvanDal>();
            services.AddScoped<IIhbarDal, EfIhbarDal>();
            services.AddScoped<IKaybolanHayvanDal, EfKaybolanHayvanDal>();
            services.AddScoped<IKullaniciDal, EfKullaniciDal>();
            services.AddScoped<IRaporDal, EfRaporDal>();
            services.AddScoped<ISahiplendirilecekHayvanDal, EfSahiplendirilecekHayvanDal>();
            services.AddScoped<ITurDal, EfTurDal>();
            services.AddScoped<IRolDal, EfRolDal>();
            services.AddScoped<IKullaniciRolDal, EfKullaniciRolDal>();

            services.AddScoped<IJwtService, JwtManager>();

            //services.AddTransient<IValidator<KullaniciSignInDto>, KullaniciSignInValidator>();
            //services.AddTransient<IValidator<KullaniciSignUpDto>, KullaniciSignUpValidator>();
            //services.AddTransient<IValidator<TurAddDto>, TurAddValidator>();
            //services.AddTransient<IValidator<TurUpdateDto>, TurUpdateValidator>();
            //services.AddTransient<IValidator<KullaniciUpdateDto>, KullaniciUpdateValidator>();
        }
    }
}
