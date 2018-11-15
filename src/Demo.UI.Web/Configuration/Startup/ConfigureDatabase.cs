using Demo.Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.UI.Web.Configuration.Startup
{
    public static partial class ConfigurationExtensions
    {
        public static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration config, IHostingEnvironment env)
        {
            if (env.IsProduction())
            {
                services.AddDbContext<DemoDbContext>(c =>
                {
                    try
                    {
                        c.UseSqlite(config.GetConnectionString("DemoDbProduction"), b => b.MigrationsAssembly("Demo.UI.Web"));
                    }
                    catch (System.Exception ex)
                    {
                        var message = ex.Message;
                    }
                });

            }
            if (env.IsStaging())
            {

            }
            if (env.IsDevelopment())
            {
                services.AddDbContext<DemoDbContext>(c =>
                {
                    try
                    {
                        c.UseSqlite(config.GetConnectionString("DemoDbDevelopment"), b => b.MigrationsAssembly("Demo.UI.Web"));
                    }
                    catch (System.Exception ex)
                    {
                        var message = ex.Message;
                    }
                });

            }
            
            return services;
        }

        //public static IApplicationBuilder ConfigureDatabase(this IApplicationBuilder app)
        //{
            
        //}
    }
}
