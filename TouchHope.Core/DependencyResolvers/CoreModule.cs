using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TouchHope.Core.CrossCuttingConcerns.Caching;
using TouchHope.Core.CrossCuttingConcerns.Caching.Microsoft;
using TouchHope.Core.Utilities.IoC;

namespace TouchHope.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<ICacheManager, MemoryCacheManager>();
            services.AddSingleton<Stopwatch>();
        }
    }
}
