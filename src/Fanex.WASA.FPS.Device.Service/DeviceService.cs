using Fanex.WASA.FPS.Device.DataAccess;
using Fanex.WASA.FPS.Device.Model.Entity;

namespace Fanex.WASA.FPS.Device.Service
{
    public interface IDeviceService
    {
        void InsertNewDevice(InsNewDeviceEntity entity);

        void UpdDevice(UpdDeviceEntity entity);
    }

    public class DeviceService : IDeviceService
    {
        private readonly IDeviceDataAccess deviceDataAccess;

        public DeviceService(IDeviceDataAccess deviceDataAccess)
        {
            this.deviceDataAccess = deviceDataAccess;
        }

        public void InsertNewDevice(InsNewDeviceEntity entity)
        {
            deviceDataAccess.InsertNewDevice(entity);
        }

        public void UpdDevice(UpdDeviceEntity entity)
        {
            deviceDataAccess.UpdDevice(entity);
        }
    }
}
