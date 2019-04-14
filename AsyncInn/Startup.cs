using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using AsyncInn.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AsyncInn
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddMvc();
            services.AddDbContext<AsyncdbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ProductionConnection")));
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            /*string connectionString = Environment.IsDevelopment()
                                         ? Configuration["ConnectionString:DefaultConnection"]
                                         : Configuration["ConnectionString:ProductionConnection"]; 

             services.AddDbContext<AsyncdbContext>(options =>
        options.UseSqlServer(connectionString));*/


            services.AddScoped<IHotelManager, HotelService>();
            services.AddScoped<IRoom, RoomService>();
            services.AddScoped<IAmenities, AmenetiesService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //uses static files
            app.UseStaticFiles();
            //checks what stage of development proj is at
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //route scaffold
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Hotels}/{action=Index}/{id?}");
            });
            //proof of life


        }

    }
}
