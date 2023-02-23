using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TouchHope.Core.Utilities.IoC;

namespace TouchHopeCore.Extensions
{
    public static class ServiceCollectionExtensions
    { 
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection services,ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(services);
            }

            return ServiceTool.Create(services);
        }
    }
}
