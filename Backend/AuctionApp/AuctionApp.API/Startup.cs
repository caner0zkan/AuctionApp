using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionApp.Business.Abstract;
using AuctionApp.Business.Concrete;
using AuctionApp.DataAccess.Abstract;
using AuctionApp.DataAccess.Concrete;

namespace AuctionApp.API
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
            services.AddControllers();


            services.AddSingleton<IAdminService, AdminManager>();
            services.AddSingleton<IAuctionService, AuctionManager>();
            services.AddSingleton<IAuctionStatusService, AuctionStatusManager>();
            services.AddSingleton<IBidService, BidManager>();
            services.AddSingleton<ICategoryService, CategoryManager>();
            services.AddSingleton<IImageService, ImageManager>();
            services.AddSingleton<IUserService, UserManager>();

            services.AddSingleton<IAdminRepository, AdminRepository>();
            services.AddSingleton<IAuctionRepository, AuctionRepository>();
            services.AddSingleton<IAuctionStatusRepository, AuctionStatusRepository>();
            services.AddSingleton<IBidRepository, BidRepository>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<IImageRepository, ImageRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();


            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            //app.UseStaticFiles();

            app.UseRouting();

            app.UseCors(options => 
            options.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
