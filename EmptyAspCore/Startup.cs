using EmptyAspCore.Config;
using EmptyAspCore.DAL;
using EmptyAspCore.Models;
using EmptyAspCore.Services.Repository;
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

namespace EmptyAspCore
{
    public class Startup
    {
        public IConfiguration _configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlServer(_configuration.GetConnectionString("DefaultApplicationConnection"));
            });

            services.AddControllersWithViews();
            services.AddCors(
                options=>options.AddPolicy(
                    WebConstants.ALLOWALL_POLICY,
                    builder=> 
                    builder.AllowAnyHeader()
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    
                )
                );;
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(
                  c=>c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee API V1")
                    );
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();
            
            app.UseEndpoints(endpoints =>
            {
                /* endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("Hello World!");
                 }); */

                endpoints.MapControllerRoute(
                      name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
                    


            });
        }
    }
}
