using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Accounting.Infrastructure;
using Accounting.Infrastructure.Mapper;
using AutoMapper;
using Accounting.Domain.Interfaces;
using Accounting.Domain.Repositories;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Services;
using Accounting.Domain;

namespace Accounting.Web.UI
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //For Migration
            //services.AddEntityFrameworkSqlServer()
            //.AddDbContext<AccountingDbContext>((serviceProvider, options) =>
            //options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"],
            //b => b.MigrationsAssembly("Accounting.Infrastructure")));

            //For System
            services.AddEntityFrameworkSqlServer()
            .AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"],
            b => b.MigrationsAssembly("Accounting.Infrastructure")));

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            //Account Tyype
            services.AddScoped<IAccountTypeRepository, AccountTypeRepository>();
            services.AddScoped<IAccountTypeService, AccountTypeService>();

            //Company
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            //Profit Centre
            services.AddScoped<IProfitCentreRepository, ProfitCentreRepository>();
            services.AddScoped<IProfitCentreService, ProfitCentreService>();

            //Chart of Account
            services.AddScoped<IChartOfAccountRepository, ChartOfAccountRepository>();
            services.AddScoped<IChartOfAccountService, ChartOfAccountService>();

            //Module
            services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<IModuleService, ModuleService>();

            //UserLevel
            services.AddScoped<IUserLevelRepository, UserLevelRepository>();
            services.AddScoped<IUserLevelService, UserLevelService>();
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

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
