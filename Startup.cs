using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DrCashApp.Models;
using DrCashApp.Data;
using AutoMapper;
using Newtonsoft.Json.Serialization;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace DrCashApp
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
            
            
            services.AddDbContext<LivroContext> (opt=> opt.UseSqlServer
            (Configuration.GetConnectionString("LivrosConnection")));

            services.AddControllers().AddNewtonsoftJson(s =>{
               s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<ILivroRepo, SqlLivroRepo>();
            services.AddScoped<IGeneroRepo, SqlGeneroRepo>();
            services.AddScoped<IAutorRepo, SqlAutorRepo>();
         



            services.AddCors();
            services.AddControllers();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

             
            // app.UseHttpsRedirection();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());


            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
