using System.Text.Json.Serialization;

namespace Fanex.WASA.FPS.DI.WebAPI.Models
{
    public class DeviceDetection
    {
        public Device Device
        {
            get;
            set;
        }

        public string DomainName
        {
            get;
            set;
        }

        public string Ip
        {
            get;
            set;
        }

        public string LocalIPs
        {
            get;
            set;
        }

        [JsonIgnore]
        public string RemoteIPs
        {
            get;
            set;
        }

        [JsonIgnore]
        public string ScriptRequestedIp
        {
            get;
            set;
        }

        [JsonIgnore]
        public string SubscriberRecordedIp
        {
            get;
            set;
        }

        [JsonIgnore]
        public string UrlRefererAuthority
        {
            get;
            set;
        }
    }
}