using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using AdventureWorks.API.Controllers;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using AdventureWorks.Data.Context;
using AutoMapper;
using AdventureWorks.Data.Repositories;
using AdventureWorks.Business.Mapping;
using AdventureWorks.Common.Interface;
using AdventureWorks.Business.Services;
using AdventureWorks.Common.Configuration;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System;
using Microsoft.AspNetCore.Mvc.Versioning.Conventions;

namespace AdventureWorks.API
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
            services.AddDbContext<AdventureWorksContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("AdventureWorksDb"));
            });

            services.AddCors();
            //We set the default for all controllers to be authorize
            services.AddControllers(opt => opt.Filters.Add(new AuthorizeFilter()))
                .AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true);

            // configure DI for application services
            services.AddScoped<IPersonService, PersonService>();

            // configure DI for application repositories
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            services.AddAutoMapper(typeof(MapperProfile));

            services.AddApiVersioning(opt =>
            {
                var version = new ApiVersion(1, 0);
                var version2 = new ApiVersion(2, 0);
                var allVersions = new ApiVersion[] { version, version2 };

                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = version;
                opt.ReportApiVersions = true;
                //We set two possible versioning just in case
                opt.ApiVersionReader = ApiVersionReader.Combine(
                    new HeaderApiVersionReader("X-Version"),
                    new QueryStringApiVersionReader("version")
                    );

                opt.Conventions.Controller<AuthenticationController>()
                    .HasApiVersions(allVersions);

                var personConventions = opt.Conventions.Controller<PersonController>()
                    .HasApiVersions(allVersions);

                personConventions.Action(a => a.Get()).MapToApiVersion(version);
                personConventions.Action(a => a.GetVersion2()).MapToApiVersion(version2);
            });

            services.AddMvc(opt => opt.EnableEndpointRouting = false);

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                };
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // global cors policy
            app.UseCors(x => x
                .SetIsOriginAllowed(origin => true)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
