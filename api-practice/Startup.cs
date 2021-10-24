﻿using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace api_practice
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

            // enable swagger
            // services.AddSwaggerGen();
            services
                .AddSwaggerGen(c =>
                {
                    var xmlFile =
                        $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath =
                        Path.Combine(AppContext.BaseDirectory, xmlFile);
                    c.IncludeXmlComments (xmlPath);
                });

           services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // swagger enable
            app.UseSwagger();

            // app.UseSwaggerUI();
            app
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Alstom API");
                    c.RoutePrefix = String.Empty;
                });

            app.UseRouting();

            app
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });

            app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
        }
    }
}
