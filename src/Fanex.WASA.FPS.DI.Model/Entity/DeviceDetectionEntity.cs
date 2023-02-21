namespace Fanex.WASA.FPS.DI.Model.Entity
{
    public class DeviceDetectionEntity
    {
        public string GpuCode { get; set; }
        public string SubscriberRecordedIp { get; set; }
        public string ScriptRequestedIp { get; set; }
        public string RemoteIPs { get; set; }
        public string LocalIPs { get; set; }
        public string Ip { get; set; }
        public string Headers { get; set; }
        public string Accept { get; set; }
        public short DeviceType { get; set; }
        public string Browser { get; set; }
        public int? SystemTimeOffset { get; set; }
        public int? TimeZone { get; set; }
        public string Fonts { get; set; }
        public string WebGL { get; set; }
        public bool? DomainSameReferrer { get; set; }
        public string SuperCookies { get; set; }
        public bool DoNotTrack { get; set; }
        public bool CookieEnabled { get; set; }
        public string Language { get; set; }
        public long? Monitor { get; set; }
        public string Screen { get; set; }
        public string UserAgent { get; set; }
        public string MimeTypes { get; set; }
        public string Plugins { get; set; }
        public string Navigator { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceId { get; set; }
        public string DomainName { get; set; }
    }
}