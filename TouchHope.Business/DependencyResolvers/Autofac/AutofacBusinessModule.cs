using Autofac;
using Autofac.Extras.DynamicProxy;
using BlogProject.Business.Abstract;
using BlogProject.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Business.Abstract;
using TouchHope.Business.Concrete;
using TouchHope.Business.Utilities.Jwt;
using TouchHope.Core.Utilities.Interceptors;
using TouchHope.DataAccess.Abstract;
using TouchHope.DataAccess.Concrete.Repositories;

namespace TouchHope.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericManager<>)).As(typeof(IGenericService<>));
            builder.RegisterGeneric(typeof(EfGenericDal<>)).As(typeof(IGenericDal<>));

            builder.RegisterType<KullaniciManager>().As<IKullaniciService>();
            builder.RegisterType<EfKullaniciDal>().As<IKullaniciDal>();

            builder.RegisterType<RolManager>().As<IRolService>();
            builder.RegisterType<EfRolDal>().As<IRolDal>();

            builder.RegisterType<CinsiyetManager>().As<ICinsiyetService>();
            builder.RegisterType<EfCinsiyetDal>().As<ICinsiyetDal>();

            builder.RegisterType<IlManager>().As<IIlService>();
            builder.RegisterType<EfIlDal>().As<IIlDal>();

            builder.RegisterType<KullaniciRolManager>().As<IKullaniciRolService>();
            builder.RegisterType<EfKullaniciRolDal>().As<IKullaniciRolDal>();

            builder.RegisterType<JwtManager>().As<IJwtService>();

            builder.RegisterType<TurManager>().As<ITurService>();
            builder.RegisterType<EfTurDal>().As<ITurDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
