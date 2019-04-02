using System.Reflection;
using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;

namespace SaveBridge
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<SaveBridgeContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper();

            services.Scan(scan => scan
                .FromAssemblyOf<IBuildingConstructionService>()
                .AddClasses()
                .AsImplementedInterfaces()
                .WithTransientLifetime()
                .FromAssemblyOf<IBuildingConstructionRepository>()
                .AddClasses()
                .AsImplementedInterfaces()
                .WithTransientLifetime());
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "api/{controller}/{action}");
            });
        }
    }
}
