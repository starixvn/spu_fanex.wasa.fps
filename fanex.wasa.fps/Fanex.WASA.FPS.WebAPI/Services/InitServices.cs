using Fanex.WASA.FPS.DI.DataAccess;
using Fanex.WASA.FPS.DI.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fanex.WASA.FPS.DI.WebAPI.Services
{
    public static class InitServices
    {
        public static void RegisterService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IOffsetDataAccess, OffsetDataAccess>();
            services.AddSingleton<IOffsetService, OffsetService>();
        }
    }
}
