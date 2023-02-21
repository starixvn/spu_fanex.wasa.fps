using Fanex.WASA.FPS.DI.DataAccess;
using Fanex.WASA.FPS.DI.Model.Entity;

namespace Fanex.WASA.FPS.DI.Service
{
    public interface IDeviceIdentityService
    {
        void InsertDeviceIdentity(DeviceDetectionEntity entity);
        void InsertDeviceIdentityDetails(DeviceDetectionDetailsEntity entity);
    }

    public class DeviceIdentityService : IDeviceIdentityService
    {
        private readonly IDeviceIdentityDataAccess deviceIdentityDataAccess;

        public DeviceIdentityService(IDeviceIdentityDataAccess deviceIdentityDataAccess)
        {
            this.deviceIdentityDataAccess = deviceIdentityDataAccess;
        }

        public void InsertDeviceIdentity(DeviceDetectionEntity entity)
        {
            deviceIdentityDataAccess.InsertDeviceIdentity(entity);
        }

        public void InsertDeviceIdentityDetails(DeviceDetectionDetailsEntity entity)
        {
            deviceIdentityDataAccess.InsertDeviceIdentityDetails(entity);
        }
    }
}
