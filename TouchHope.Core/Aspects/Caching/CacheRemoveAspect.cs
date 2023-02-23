using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TouchHope.Core.CrossCuttingConcerns.Caching;
using TouchHope.Core.Utilities.Interceptors;
using TouchHope.Core.Utilities.IoC;

namespace TouchHope.Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect: MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;
        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
