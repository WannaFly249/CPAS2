using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace CPAS2
{
    public class CPAS2WebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<CPAS2WebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}