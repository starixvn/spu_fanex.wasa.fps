using Microsoft.Extensions.Configuration;
using System;
using System.ComponentModel;

namespace Fanex.WASA.FPS.DI.WebAPI
{
    public interface IAppSettings
    {
        string SPName { get; }
        string SentryDsn { get; }
    }

    public class AppSettings : IAppSettings
    {
        private readonly IConfiguration configuration;

        private readonly string spName;

        private readonly string sentryDsn;

        public AppSettings(IConfiguration configuration)
        {
            this.configuration = configuration;

            spName = GetValue<string>("AppConfig:SPName");

            sentryDsn = GetValue<string>("Sentry:Dsn");
        }

        public string SPName => spName;

        public string SentryDsn => sentryDsn;

        public T GetValue<T>(string key)
        {
            try
            {
                var value = configuration[key];

                var typeConverter = TypeDescriptor.GetConverter(typeof(T));

                return (T)typeConverter.ConvertFromString(value);
            }
            catch (Exception ex)
            {
                throw new InvalidCastException($"Key: {key}", ex);
            }
        }

        public T GetSection<T>(string key)
        {
            var schedulerSection = configuration.GetSection(key);

            return schedulerSection.Get<T>();
        }
    }
}