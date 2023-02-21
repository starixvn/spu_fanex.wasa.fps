using System;

namespace Fanex.WASA.FPS.Device.Model.Entity
{
    public class UpdDeviceEntity
    {
        public int? DeviceId { get; set; }

        public DateTime? CapturedDate { get; set; }

        public int SubscriberId { get; set; }

        public string DeviceCode { get; set; }

        public string Browser { get; set; }

        public long PluginId { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
