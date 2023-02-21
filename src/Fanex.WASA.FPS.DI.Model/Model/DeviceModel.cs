using System;

namespace Fanex.WASA.FPS.DI.Model.Model
{
    public class DeviceModel
    {
        public string ClientDeviceIds { get; set; }

        public string Code { get; set; }

        public string Navigator { get; set; }

        public string Plugins { get; set; }

        public string MimeTypes { get; set; }

        public string UserAgent { get; set; }

        public string Screen { get; set; }

        public string Monitor { get; set; }

        public string Fonts { get; set; }

        public int? TimeZone { get; set; }

        public string GPUCode { get; set; }

        public string WebGL { get; set; }

        public string Language { get; set; }

        public int? SystemTimeOffset { get; set; }

        public bool CookieEnabled { get; set; }

        public bool DoNotTrack { get; set; }

        public string SuperCookies { get; set; }

        public string Browser { get; set; }

        public short DeviceType { get; set; }

        public string Accept { get; set; }

        public string Headers { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string Id { get; set; }

        public ulong? IdRef { get; set; }

        public ulong Increment { get; set; }
    }
}