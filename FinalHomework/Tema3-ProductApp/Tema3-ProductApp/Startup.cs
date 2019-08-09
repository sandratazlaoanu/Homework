using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tema3_ProductApp.DatabaseContext;
using Tema3_ProductApp.Repositories;

namespace Tema3_ProductApp
{
    public class Startup
    {
        readonly IConfiguration _configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"]));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            //app.UseMvc(ConfigureRoutes);
            app.UseMvcWithDefaultRoute();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    // await context.Response.WriteAsync("Hello World!");
            //});
        }

        /*private void ConfigureRoutes(IRouteBuilder routes)
        {
            routes.MapRoute(null, "{controller = Product}/{action = Index}/{id?}");
        }*/
    }
}
