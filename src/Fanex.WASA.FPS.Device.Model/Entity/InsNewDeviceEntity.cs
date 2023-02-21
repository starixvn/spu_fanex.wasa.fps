using System;

namespace Fanex.WASA.FPS.Device.Model.Entity
{
    public class InsNewDeviceEntity
    {
        public string DeviceNo { get; set; }

        public int DeviceType { get; set; }

        public string OsName { get; set; }

        public int SubscriberId { get; set; }

        public string DeviceCode { get; set; }

        public string Browser { get; set; }

        public long PluginId { get; set; }

        public DateTime CreatedDate { get; set; }

        public int DeviceId { get; set; }

        public DateTime CapturedDate { get; set; }
    }
}
