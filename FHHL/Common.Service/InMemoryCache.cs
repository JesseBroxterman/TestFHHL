using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq.Expressions;
using System.Text;

namespace Common.Service
{
    public interface ICache
    {
        T Get<T>(Expression<Func<T>> updateExpression = null, string key = null, int cacheDuration = 360);
    }

    public class InMemoryCache : ICache
    {
        private readonly IMemoryCache _memoryCache;

        public InMemoryCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public T Get<T>(Expression<Func<T>> updateExpression = null, string key = null, int cacheDuration = 300)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                var methodCallExpression = updateExpression.Body as MethodCallExpression;
                if (methodCallExpression == null)
                    throw new Exception("In order to use this service with a non-method expression the key argument will need to be provided");

                var method = methodCallExpression.Method;

                var sb = new StringBuilder();
                foreach (var a in methodCallExpression.Arguments)
                {
                    if (sb.Length > 0)
                        sb.Append(", ");

                    var lambda = Expression.Lambda(a);
                    var compiledLambda = lambda.Compile();
                    var value = compiledLambda.DynamicInvoke() ?? "null";

                    sb.Append(value.ToString());
                }

                key = $"{method.DeclaringType.FullName}.{method.Name}({sb.ToString()})";
            }

            if (_memoryCache.TryGetValue(key, out object result))
                return (T)result;
            else
            {
                if (updateExpression == null)
                    return default(T);

                var func = updateExpression.Compile();

                var data = func();
                if (true || data != null)
                {
                    var absoluteExpiration = DateTime.Today.AddHours(6);
                    if (absoluteExpiration < DateTime.Now)
                        absoluteExpiration = absoluteExpiration.AddDays(1);

                    var options = new MemoryCacheEntryOptions
                    {
                        AbsoluteExpiration = absoluteExpiration,
                        SlidingExpiration = TimeSpan.FromSeconds(cacheDuration)
                    };
                    _memoryCache.Set(key, data, options);
                    return data;
                }
                return default(T);
            }
        }
    }
}