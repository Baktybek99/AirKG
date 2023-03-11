using AirKG.Context;
using AirKG.Entity;
using AirKG.Profiles;
using AirKG.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace AirKG
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// сюда добавляешь свои автомаперы
        /// </summary>
        private Assembly[] assemblies = new Assembly[]
        {
            //Пример
            //typeof(*Название Класса*).Assembly,
            typeof(EntitytProfile).Assembly
        };

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ///Регистрация базы данных
            services.AddDbContext<AirKGDbContext>(x =>
                                                x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            ///Регистрация сервисов
            services.AddScoped<AirDataService>();
            services.AddScoped<DistrictService>();
            services.AddScoped<SensorService>();
            services.AddScoped<ChartService>();

            ///Для отключения валидации пароля
            services.AddIdentity<User, IdentityRole>(x =>
            {
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequiredLength = 3;
                x.Password.RequireUppercase = false;
                x.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<AirKGDbContext>();

            services.AddAutoMapper(assemblies);
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
