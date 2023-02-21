using Fanex.Data.Repository;
using Fanex.WASA.FPS.Device.DataAccess.Criteria;
using Fanex.WASA.FPS.Device.Model.Entity;

namespace Fanex.WASA.FPS.Device.DataAccess
{
    public interface IDeviceDataAccess
    {
        void InsertNewDevice(InsNewDeviceEntity entity);

        void UpdDevice(UpdDeviceEntity entity);
    }

    public class DeviceDataAccess : IDeviceDataAccess
    {
        private readonly IDynamicRepository repository;

        public DeviceDataAccess()
        {
            repository = new DynamicRepository();
        }

        public void InsertNewDevice(InsNewDeviceEntity entity)
        {
            var criteria = new InsNewDeviceCriteria
            {
                Browser = entity.Browser,
                CapturedDate = entity.CapturedDate,
                CreatedDate = entity.CreatedDate,
                DeviceCode = entity.DeviceCode,
                DeviceId = entity.DeviceId,
                DeviceNo = entity.DeviceNo,
                DeviceType = entity.DeviceType,
                OsName = entity.OsName,
                PluginId = entity.PluginId,
                SubscriberId = entity.SubscriberId
            };

            repository.Execute(criteria);
        }

        public void UpdDevice(UpdDeviceEntity entity)
        {
            var criteria = new UpdDeviceCriteria
            {
                Browser = entity.Browser,
                CapturedDate = entity.CapturedDate,
                CreatedDate =entity.CreatedDate,
                DeviceCode = entity.DeviceCode,
                DeviceId = entity.DeviceId,
                PluginId = entity.PluginId,
                SubscriberId = entity.SubscriberId
            };

            repository.Execute(criteria);
        }
    }
}
