using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace ProjectDock
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

            // Cross Origin Resource Sharing.(Gives permission to frontend angular service to make requests.)
            // In the production env consider using a proxy
            services.AddCors(options => options.AddPolicy("Cors",
                builder =>
                {
                    builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));

            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseCors("Cors");

            app.UseAuthentication();

            app.UseMvc();

            //var a = app.ApplicationServices.GetService<ApiContext>();
            //this.SeedData(app.ApplicationServices.GetService<ApiContext>());

        }
/*
        public void SeedData(ApiContext context)
        {
            context.Projects.Add(new Models.Project
            {
                name = "GitHub",
                description = "The Sourse storage website."

            });
            context.Projects.Add(new Models.Project
            {
                name = "Electron",
                description = "Cross platform for web applications..."

            });
        }
*/
    }
}
