using System;

namespace Fanex.WASA.FPS.Device.Model.Entity
{
    public class UpdDeviceEntity
    {
        private readonly int? deviceId;
        private readonly DateTime? capturedDate;
        private readonly int subscriberId;
        private readonly string deviceCode;
        private readonly string browser;
        private readonly long pluginId;
        private readonly DateTime? createdDate;

        public UpdDeviceEntity(int? deviceId, DateTime? capturedDate, int subscriberId, string deviceCode, string browser, long pluginId, DateTime? createdDate)
        {
            this.deviceId = deviceId;
            this.capturedDate = capturedDate;
            this.subscriberId = subscriberId;
            this.deviceCode = deviceCode;
            this.browser = browser;
            this.pluginId = pluginId;
            this.createdDate = createdDate;
        }

        public int? DeviceId => deviceId;

        public DateTime? CapturedDate => capturedDate;

        public int SubscriberId => subscriberId;

        public string DeviceCode => deviceCode;

        public string Browser => browser;

        public long PluginId => pluginId;

        public DateTime? CreatedDate => createdDate;
    }
}
