using Demo.Domain.AggregatesModel.BookAggregate;
using Demo.Domain.AggregatesModel.UserAggregate;
using Demo.Domain.Application.Core;
using Demo.Domain.SeedWork;
using Demo.Infrastructure.Data;
using Demo.Infrastructure.Repository;
using Demo.UI.Web.Configuration.Startup;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Demo.UI.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment enviroment)
        {
            Configuration = configuration;
            Enviroment = enviroment;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment Enviroment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<DemoDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureDatabase(Configuration, Enviroment);
            AddMediatr(services);


            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddScoped<IBookRepository, BookRepository>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                 app.UseHsts();
            }

            
            app.UseStaticFiles();
            app.UseCookiePolicy();          

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private static void AddMediatr(IServiceCollection services)
        {
            const string applicationAssemblyName = "Demo.Domain";
            var assembly = AppDomain.CurrentDomain.Load(applicationAssemblyName);

            AssemblyScanner
                .FindValidatorsInAssembly(assembly)
                .ForEach(result => services.AddScoped(result.InterfaceType, result.ValidatorType));

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(FailFastRequestBehavior<,>));

            services.AddMediatR();
        }
    }
}
