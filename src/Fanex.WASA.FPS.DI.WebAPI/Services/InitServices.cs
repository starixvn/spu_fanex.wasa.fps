using Fanex.Logging;
using Fanex.Logging.Extensions;
using Fanex.Logging.Extensions.AspNetCore;
using Fanex.Logging.Extensions.Database;
using Fanex.Logging.Sentry.RavenClient;
using Fanex.WASA.FPS.Account.DataAccess;
using Fanex.WASA.FPS.Account.Service;
using Fanex.WASA.FPS.Association.DataAccess;
using Fanex.WASA.FPS.Association.Service;
using Fanex.WASA.FPS.Device.DataAccess;
using Fanex.WASA.FPS.Device.Service;
using Fanex.WASA.FPS.DI.DataAccess;
using Fanex.WASA.FPS.DI.Service;
using Fanex.WASA.FPS.Transaction.DataAccess;
using Fanex.WASA.FPS.Transaction.Service;
using Microsoft.Extensions.DependencyInjection;
using SharpRaven;
using System.Collections.Generic;

namespace Fanex.WASA.FPS.DI.WebAPI.Services
{
    public static class InitServices
    {
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

        public static void RegisterService(this IServiceCollection services)
        {
            RegisterDeviceIdentityService(services);
            RegisterDeviceService(services);
            RegisterAccountService(services);
            RegisterAssociationService(services);
            RegisterTransactionService(services);
        }

        private static void RegisterDeviceIdentityService(this IServiceCollection services)
        {
            services.AddSingleton<IDeviceIdentityDataAccess, DeviceIdentityDataAccess>();
            services.AddSingleton<IDeviceIdentityService, DeviceIdentityService>();
        }

        private static void RegisterDeviceService(this IServiceCollection services)
        {
            services.AddSingleton<IDeviceDataAccess, DeviceDataAccess>();
            services.AddSingleton<IDeviceService, DeviceService>();
        }

        private static void RegisterAccountService(this IServiceCollection services)
        {
            services.AddSingleton<IAccountDataAccess, AccountDataAccess>();
            services.AddSingleton<IAccountService, AccountService>();
        }

        private static void RegisterAssociationService(this IServiceCollection services)
        {
            services.AddSingleton<IAssociationDataAccess, AssociationDataAccess>();
            services.AddSingleton<IAssociationService, AssociationService>();
        }

        private static void RegisterTransactionService(this IServiceCollection services)
        {
            services.AddSingleton<ITransactionDataAccess, TransactionDataAccess>();
            services.AddSingleton<ITransactionService, TransactionService>();
        }

    }
}
