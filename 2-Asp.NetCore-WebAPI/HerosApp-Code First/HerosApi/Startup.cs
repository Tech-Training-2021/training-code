using HerosData;
using HerosData.Entities;
using HerosLogic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//[assembly:ApiController]
namespace HerosApi
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
            services.AddAuthentication(opt=> {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options=>
                        {
                            // the token is going to validate if
                            options.TokenValidationParameters = new TokenValidationParameters
                            {
                                //the issuer is the actual server that created the token
                                ValidateIssuer = true,
                                // the reciever of the token is a valid recipient
                                ValidateAudience = true,
                                // the token has not expired
                                ValidateLifetime = true,
                                //the signing key is valid and trusted by the server
                                ValidateIssuerSigningKey = true,

                                ValidIssuer = "https://superherowebapi.azurewebsites.net/", //Configuration["ValidIssuer"],
                                ValidAudience = "https://superherowebapi.azurewebsites.net/",//Configuration["ValidAudience"],
                                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"))//(Configuration["IssuerSigningKey"]))
                            };
                        }
                );
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("*").AllowAnyOrigin();
                });
                //options.AddPolicy("Policy1",
                //    builder =>
                //    {
                //        builder.WithOrigins("http://example.com",
                //                            "http://www.contoso.com");
                //    });

                //options.AddPolicy("AnotherPolicy",
                //    builder =>
                //    {
                //        builder.WithOrigins("http://www.contoso.com")
                //                            .AllowAnyHeader()
                //                            .AllowAnyMethod();
                //    });
            });

            services.AddControllers(options =>
                //returns 406 Not Acceptable-if no formatter is found to satisfy client's request
                options.ReturnHttpNotAcceptable = true).AddXmlSerializerFormatters();// to add another formatter in Asp.Net core middleware
            services.AddDbContext<SuperHeroContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HerosDb")));
            // code for inmemory data
            //services.AddDbContext<SuperHeroContext>(options =>
                            //options.UseInMemoryDatabase("HerosDb"));
            services.AddScoped<ISuperHeroRepo, DbRepo>();
            services.AddScoped<ISuperPowerRepo, DbRepo>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SuperHeros Api", Version = "v1" });

                // Set the comments path for the swagger JSON and UI
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

            });
        }
        //Middlewares configured
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SuperHeros Api v1"));
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseHttpsRedirection();

            app.UseRouting();// this middleware is used to configure endpoints 
            app.UseCors();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>  // this middleware executes those endpoints
            {
                endpoints.MapControllers();
            });
        }
    }
}
