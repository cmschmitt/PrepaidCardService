using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrepaidCardService.Externals;
using PrepaidCardService.Interfaces;

namespace PrepaidCardService
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

            services.AddScoped<IFirst, First>();
            services.AddScoped<ISecond, Second>();
            services.AddScoped<IBalanceInquiryService<IFirst>, FirstBalanceInquiryService>();
            services.AddScoped<IBalanceInquiryService<ISecond>, SecondBalanceInquiryService>();
            services.AddScoped<IPrepaidCardService, PrepaidCardProcessor>();
            services.AddSingleton(new BalanceInquiryServiceFactory(services.BuildServiceProvider()));
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
            app.UseMvc();
        }
    }
}
