using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HylianRIS_API.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]
    public class ClientAppApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var invalidResult = new ContentResult() { StatusCode = 401 };
            if (!context.HttpContext.Request.Headers.TryGetValue(Constants.ApiKeyName, out var extractedApiKey))
            {
                context.Result = invalidResult;
                return;
            }

            var configuration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var validKeys = JsonConvert.DeserializeObject<List<ClientAppKey>>(configuration["ClientAppKeys"]);

            if (!validKeys.Any(k => k.Key.Equals(extractedApiKey, StringComparison.InvariantCultureIgnoreCase)))
            {
                context.Result = invalidResult;
                return;
            }

            await next();
        }

        private class ClientAppKey
        {
            public string Key { get; set; }
            public string Name { get; set; }
        } 
    }
}
