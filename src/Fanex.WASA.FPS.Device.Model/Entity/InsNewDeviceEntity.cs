using System;

namespace Fanex.WASA.FPS.Device.Model.Entity
{
    public class InsNewDeviceEntity
    {
        private readonly string deviceNo;
        private readonly int deviceType;
        private readonly string osName;
        private readonly int subscriberId;
        private readonly string deviceCode;
        private readonly string browser;
        private readonly long pluginId;
        private readonly DateTime createdDate;
        private readonly int deviceId;
        private readonly DateTime capturedDate;

        public InsNewDeviceEntity(string deviceNo, int deviceType, string osName, int subscriberId, string deviceCode, string browser, long pluginId, DateTime createdDate, int deviceId)
        {
            this.deviceNo = deviceNo;
            this.deviceType = deviceType;
            this.osName = osName;
            this.subscriberId = subscriberId;
            this.deviceCode = deviceCode;
            this.browser = browser;
            this.pluginId = pluginId;
            this.createdDate = createdDate;
            this.deviceId = deviceId;
        }

        public string DeviceNo => deviceNo;

        public int DeviceType => deviceType;

        public string OsName => osName;

        public int SubscriberId => subscriberId;

        public string DeviceCode => deviceCode;

        public string Browser => browser;

        public long PluginId => pluginId;

        public DateTime CreatedDate => createdDate;

        public int DeviceId => deviceId;

        public DateTime CapturedDate => capturedDate;
    }
}
