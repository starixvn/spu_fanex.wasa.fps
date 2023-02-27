namespace Fanex.WASA.FPS.DI.Model.Entity
{
    public class DeviceDetectionEntity
    {
        private readonly string gpuCode;
        private readonly string subscriberRecordedIp;
        private readonly string scriptRequestedIp;
        private readonly string remoteIPs;
        private readonly string localIPs;
        private readonly string ip;
        private readonly string headers;
        private readonly string accept;
        private readonly short deviceType;
        private readonly string browser;
        private readonly int? systemTimeOffset;
        private readonly int? timeZone;
        private readonly string fonts;
        private readonly string webGL;
        private readonly bool? domainSameReferrer;
        private readonly string superCookies;
        private readonly bool doNotTrack;
        private readonly bool cookieEnabled;
        private readonly string language;
        private readonly long? monitor;
        private readonly string screen;
        private readonly string userAgent;
        private readonly string mimeTypes;
        private readonly string plugins;
        private readonly string navigator;
        private readonly string deviceCode;
        private readonly string deviceId;
        private readonly string domainName;

        public DeviceDetectionEntity(string gpuCode, string subscriberRecordedIp, string scriptRequestedIp, string remoteIPs, string localIPs, string ip, string headers, string accept, short deviceType, string browser, int? systemTimeOffset, int? timeZone, string fonts, string webGL, bool? domainSameReferrer, string superCookies, bool doNotTrack, bool cookieEnabled, string language, long? monitor, string screen, string userAgent, string mimeTypes, string plugins, string navigator, string deviceCode, string deviceId, string domainName)
        {
            this.gpuCode = gpuCode;
            this.subscriberRecordedIp = subscriberRecordedIp;
            this.scriptRequestedIp = scriptRequestedIp;
            this.remoteIPs = remoteIPs;
            this.localIPs = localIPs;
            this.ip = ip;
            this.headers = headers;
            this.accept = accept;
            this.deviceType = deviceType;
            this.browser = browser;
            this.systemTimeOffset = systemTimeOffset;
            this.timeZone = timeZone;
            this.fonts = fonts;
            this.webGL = webGL;
            this.domainSameReferrer = domainSameReferrer;
            this.superCookies = superCookies;
            this.doNotTrack = doNotTrack;
            this.cookieEnabled = cookieEnabled;
            this.language = language;
            this.monitor = monitor;
            this.screen = screen;
            this.userAgent = userAgent;
            this.mimeTypes = mimeTypes;
            this.plugins = plugins;
            this.navigator = navigator;
            this.deviceCode = deviceCode;
            this.deviceId = deviceId;
            this.domainName = domainName;
        }

        public string GpuCode => gpuCode;
        public string SubscriberRecordedIp => subscriberRecordedIp;
        public string ScriptRequestedIp => scriptRequestedIp;
        public string RemoteIPs => remoteIPs;
        public string LocalIPs => localIPs;
        public string Ip => ip;
        public string Headers => headers;
        public string Accept => accept;
        public short DeviceType => deviceType;
        public string Browser => browser;
        public int? SystemTimeOffset => systemTimeOffset;
        public int? TimeZone => timeZone;
        public string Fonts => fonts;
        public string WebGL => webGL;
        public bool? DomainSameReferrer => domainSameReferrer;
        public string SuperCookies => superCookies;
        public bool DoNotTrack => doNotTrack;
        public bool CookieEnabled => cookieEnabled;
        public string Language => language;
        public long? Monitor => monitor;
        public string Screen => screen;
        public string UserAgent => userAgent;
        public string MimeTypes => mimeTypes;
        public string Plugins => plugins;
        public string Navigator => navigator;
        public string DeviceCode => deviceCode;
        public string DeviceId => deviceId;
        public string DomainName => domainName;
    }
}