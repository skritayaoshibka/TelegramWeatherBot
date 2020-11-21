using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeatherBot.Models;

namespace WeatherBot
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            SetBotSettings();
            SetOpenWeatherAPISettings();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            Bot.GetClient().Wait();
        }

        
        private void SetBotSettings()
        {
            BotSettings.Name = Configuration["BotConfiguration:Name"];
            BotSettings.Url = Configuration["BotConfiguration:Url"];
            BotSettings.Key = Configuration["BotConfiguration:Key"];
        }

        private void SetOpenWeatherAPISettings()
        {
            OpenWeatherAPISettings.Key = Configuration["OpenWaetherAPIConfiguration:Key"];
        }
    }
}