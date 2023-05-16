using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.DbContextFactory.Extensions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FHHL.Data.Context;
using FHHL.BLL.Services;
using Common.Web.Json;
using FHHL.BLL.Interfaces;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using StackifyLib;

namespace FHHL.Web
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
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            services.AddDbContextFactory<FHHLDbContext>(options =>
            {
                options.UseSqlServer(Configuration[$"{env}-ConnectionStrings-FHHL"]);
            });

            services.AddControllersWithViews()
    .AddRazorRuntimeCompilation();

            services.AddTransient<IOptionsService, OptionsService>();
            services.AddTransient<IReferralService, ReferralService>();
            services.AddTransient<ICaregiverService, CaregiverService>();

            services.AddMemoryCache();
            services.AddDistributedMemoryCache();

            services
                .AddMvc()
                .AddJsonOptions(options =>
                {
                    var converters = options.JsonSerializerOptions.Converters;
                    converters.Add(new DecimalToStringConverter());
                    converters.Add(new IntToStringConverter());
                })
                .AddRazorRuntimeCompilation()
                .AddSessionStateTempDataProvider();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(365);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.Name = "FHHL.Session";
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAuthentication(AzureADDefaults.AuthenticationScheme)
                .AddAzureAD(options => Configuration.Bind("AzureAd", options));

            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Local"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.ConfigureStackifyLogging(Configuration);
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSession();
            app.UseRouting();
            app.UseAuthorization();

            app.UseRewriter(new RewriteOptions().Add(context =>
            {
                if (context.HttpContext.Request.Path == "/AzureAD/Account/SignedOut")
                {
                    context.HttpContext.Response.Redirect("/Home/Index");
                }
            }));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
