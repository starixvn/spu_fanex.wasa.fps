using Fanex.Data.Repository;
using Fanex.WASA.FPS.DI.DataAccess.Criteria;
using Fanex.WASA.FPS.DI.Model;

namespace Fanex.WASA.FPS.DI.DataAccess
{
    public interface IDeviceIdentityDataAccess
    {
        void InsertDeviceIdentity(DeviceDetectionEntity entity);
        void InsertDeviceIdentityDetails(DeviceDetectionDetailsEntity entity);
    }

    public class DeviceIdentityDataAccess : IDeviceIdentityDataAccess
    {
        private readonly IDynamicRepository repository;

        public DeviceIdentityDataAccess()
        {
            repository = new DynamicRepository();
        }

        public void InsertDeviceIdentity(DeviceDetectionEntity entity)
        {
            var criteria = new DeviceIdentityInsertCriteria
            {
                Accept = entity.Accept,
                Browser = entity.Browser,
                CookieEnabled = entity.CookieEnabled,
                DeviceId = entity.DeviceId,
                DeviceCode = entity.DeviceCode,
                DeviceType = entity.DeviceType,
                DomainName = entity.DomainName,
                DomainSameReferrer = entity.DomainSameReferrer ?? false,
                DoNotTrack = entity.DoNotTrack,
                Fonts = entity.Fonts,
                GPUCode = entity.GpuCode,
                Headers = entity.Headers,
                Ip = entity.Ip,
                Language = entity.Language,
                LocalIps = entity.LocalIPs,
                MimeTypes = entity.MimeTypes,
                Monitor = entity.Monitor ?? 0,
                Navigator = entity.Navigator,
                Plugins = entity.Plugins,
                RemoteIps = entity.RemoteIPs,
                Screen = entity.Screen,
                ScriptRequestedIp = entity.ScriptRequestedIp,
                SubscriberRecordedIp = entity.SubscriberRecordedIp,
                SuperCookies = entity.SuperCookies,
                SystemTimeOffset = entity.SystemTimeOffset ?? 0,
                Timezone = entity.TimeZone ?? 0,
                UserAgent = entity.UserAgent,
                WebGL = entity.WebGL,

                Msg = null,
                HasDetail = false,
                Error = null,
                DeviceIdIns = null

            };

            repository.Execute(criteria);
        }

        public void InsertDeviceIdentityDetails(DeviceDetectionDetailsEntity entity)
        {
            var criteria = new DeviceIdentityDetailsInsertCriteria
            {
                Accept = entity.Accept,
                Browser = entity.Browser,
                DeviceCode = entity.DeviceCode,
                DeviceName = entity.DeviceName,
                Engine = entity.Engine,
                Headers = entity.Headers,
                MimeTypes = entity.MimeTypes,
                Navigator = entity.Navigator,
                OS = entity.Os,
                Plugins = entity.Plugins,
                Screen = entity.Screen,
                UserAgent = entity.UserAgent,

                Msg = null,
                Error = null,
                DeviceIdIns = null
            };
            repository.Execute(criteria);
        }
    }
}
