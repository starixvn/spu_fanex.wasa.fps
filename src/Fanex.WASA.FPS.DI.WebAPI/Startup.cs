using Fanex.Data;
using Fanex.Data.MySql;
using Fanex.Logging;
using Fanex.Logging.Extensions;
using Fanex.Logging.Extensions.AspNetCore;
using Fanex.Logging.Extensions.Database;
using Fanex.Logging.Sentry.RavenClient;
using Fanex.WASA.FPS.DI.WebAPI;
using Fanex.WASA.FPS.DI.WebAPI.Extensions;
using Fanex.WASA.FPS.DI.WebAPI.Middleware;
using Fanex.WASA.FPS.DI.WebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SharpRaven;
using System.Collections.Generic;
using System.Linq;

namespace fanex.wasa.fps.webservice
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
            var appSettings = new AppSettings(Configuration);
            services.AddSingleton<IAppSettings>(appSettings);
            services.AddSingleton<ILogger, Logger>();

            services.AddCors(opt =>
            {
                opt.AddDefaultPolicy(builder => builder
                    .WithOrigins("*")
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Fanex.WASA.FPS.DI.WebAPI", Version = "v1" });
            });

            services.AddHealthChecks();

            services.RegisterService(Configuration);

            //FanexDataConfig(appSettings);

            LogManager
           .SetDefaultLogCategory("Fanex.WASA.FPS.DI.WebAPI")
           .Use(new List<ILogEngine>
           {
                     new SentryLogging(new SentryEngineOptions
                     {
                         Dsn = new Dsn(appSettings.SentryDsn)
                     })
           });

            ExceptionHandler
                .UseConfig(new LoggingConfiguration())
                .UseGetDbExceptionInfo(DatabaseInfoGetters.GetDbExceptionInfo);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseMiddleware<ExceptionMiddleware>();

            app.UserFanexDataWithMySql(Configuration);

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("v1/swagger.json", "Fanex.WASA.FPS.DI.WebAPI v1"));

            app.UseHealthChecks("/healthz", new HealthCheckOptions
            {
                Predicate = _ => true
            });

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        //private void FanexDataConfig(IAppSettings appSettings)
        //{
        //    var connections = Configuration
        //                          .GetSection("AppConfig:Connections")
        //                          .GetChildren()
        //                          .AsEnumerable()
        //                          .ToDictionary(
        //                                   x => x.GetValue<string>("Name"),
        //                                   y => new ConnectionConfiguration(y.GetValue<string>("Name"), y.GetValue<string>("ConnectionString"), y.GetValue<string>("ProviderName"))
        //                           );

        //    DbSettingProviderManager
        //      .StartNewSession()
        //      .Use(connections)
        //      .WithMySql()
        //      .UseDefaultDbSettingProvider(resourcePath: appSettings.SPName)
        //      .Run();
        //}
    }
}
