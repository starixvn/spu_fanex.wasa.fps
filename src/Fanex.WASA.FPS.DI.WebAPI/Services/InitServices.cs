using Fanex.Logging.Extensions.AspNetCore;
using Fanex.Logging.Extensions.Database;
using Fanex.Logging.Extensions;
using Fanex.Logging.Sentry.RavenClient;
using Fanex.Logging;
using Fanex.WASA.FPS.DI.DataAccess;
using Fanex.WASA.FPS.DI.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharpRaven;
using System.Collections.Generic;

namespace Fanex.WASA.FPS.DI.WebAPI.Services
{
    public static class InitServices
    {
        public static void RegisterService(this IServiceCollection services)
        {
            services.AddSingleton<IDeviceIdentityDataAccess, DeviceIdentityDataAccess>();
            services.AddSingleton<IDeviceIdentityService, DeviceIdentityService>();
        }

        public static void AddSentryLogs(this IServiceCollection services, IAppSettings appSettings)
        {
            LogManager
           .SetDefaultLogCategory("Fanex.WASA.FPS.DI.WebAPI")
           .Use(new List<ILogEngine>
           {
                     new SentryLogging(new SentryEngineOptions
                     {
                         Dsn = new Dsn(appSettings.SentryDsn)
                     })
           });
        }

        public static void AddExceptionHandler(this IServiceCollection services)
        {            

            ExceptionHandler
                .UseConfig(new LoggingConfiguration())
                .UseGetDbExceptionInfo(DatabaseInfoGetters.GetDbExceptionInfo);
        }
    }
}
