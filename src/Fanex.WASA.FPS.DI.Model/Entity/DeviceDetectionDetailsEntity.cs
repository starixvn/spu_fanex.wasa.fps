namespace Fanex.WASA.FPS.DI.Model.Entity
{
    public class DeviceDetectionDetailsEntity
    {
        private readonly string deviceCode;
        private readonly string navigator;
        private readonly string plugins;
        private readonly string mimeTypes;
        private readonly string userAgent;
        private readonly string screen;
        private readonly string os;
        private readonly string browser;
        private readonly string engine;
        private readonly string deviceName;
        private readonly string accept;
        private readonly string headers;

        public DeviceDetectionDetailsEntity(string deviceCode, string navigator, string plugins, string mimeTypes, string userAgent, string screen, string os, string browser, string engine, string deviceName, string accept, string headers)
        {
            this.deviceCode = deviceCode;
            this.navigator = navigator;
            this.plugins = plugins;
            this.mimeTypes = mimeTypes;
            this.userAgent = userAgent;
            this.screen = screen;
            this.os = os;
            this.browser = browser;
            this.engine = engine;
            this.deviceName = deviceName;
            this.accept = accept;
            this.headers = headers;
        }

        public string DeviceCode => deviceCode;

        public string Navigator => navigator;

        public string Plugins => plugins;

        public string MimeTypes => mimeTypes;

        public string UserAgent => userAgent;

        public string Screen => screen;

        public string Os => os;

        public string Browser => browser;

        public string Engine => engine;

        public string DeviceName => deviceName;

        public string Accept => accept;

        public string Headers => headers;
    }
}
