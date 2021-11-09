using HamnavaKala.Core.Interfaces;
using HamnavaKala.Core.Servieces;
using HamnavaKala.DataLayer.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HamnavaKala.Core.Classes.RenderEmail;

namespace HamnavaKala
{
    public class Startup
    {
        public const string Schema = "HamnavaMarket";
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDbContext<HamnavaKalaContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectoin"));
            });

            // login part
            services.AddAuthentication(Schema)
               .AddCookie(Schema, option =>
               {
                   option.LoginPath = "/Account/Login";
                   option.AccessDeniedPath = "/Account/Login";
                   option.ExpireTimeSpan = TimeSpan.FromDays(30);

               });

            #region IOC
            services.AddTransient<ISlider, SliderService>();
            services.AddTransient<IProductServices, ProductServices>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IGurantee, GuranteeService>();
            services.AddTransient<IBrand, BrandService>();
            services.AddTransient<IUserservice, Userservice>();
            services.AddTransient<IViewRenderService, RenderViewToString>();
            services.AddTransient<IAddressService, AddressService>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage();
            app.UseAuthentication();
            app.UseRouting();
            app.UseStatusCodePagesWithRedirects("/Home/Error");
            app.UseAuthorization();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Area", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{Controller=Home}/{action=Index}/{Id?}");
            });
        }
    }
}
