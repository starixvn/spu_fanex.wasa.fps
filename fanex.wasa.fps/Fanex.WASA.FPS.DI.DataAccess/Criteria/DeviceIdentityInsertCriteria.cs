using Fanex.Data;
using Fanex.Data.Repository;

namespace Fanex.WASA.FPS.DI.DataAccess.Criteria
{
    public class DeviceIdentityInsertCriteria : NonQueryCommand
    {
        [SpParam(SqlParamName = "ip_DeviceId")]
        public string OffsetName { get; set; }

        [SpParam(SqlParamName = "ip_DeviceCode")]
        public string DeviceCode { get; set; }

        [SpParam(SqlParamName = "ip_Navigator")]
        public string Navigator { get; set; }

        [SpParam(SqlParamName = "ip_Plugins")]
        public string Plugins { get; set; }

        [SpParam(SqlParamName = "ip_MimeTypes")]
        public string MimeTypes { get; set; }

        [SpParam(SqlParamName = "ip_UserAgent")]
        public string UserAgent { get; set; }

        [SpParam(SqlParamName = "ip_Fonts")]
        public string Fonts { get; set; }

        [SpParam(SqlParamName = "ip_Screen")]
        public string Screen { get; set; }

        [SpParam(SqlParamName = "ip_Monitor")]
        public long Monitor { get; set; }

        [SpParam(SqlParamName = "ip_Timezone")]
        public int Timezone { get; set; }

        [SpParam(SqlParamName = "ip_GPUCode")]
        public string GPUCode { get; set; }

        [SpParam(SqlParamName = "ip_WebGL")]
        public string WebGL { get; set; }

        [SpParam(SqlParamName = "ip_Language")]
        public string Language { get; set; }

        [SpParam(SqlParamName = "ip_CookieEnabled")]
        public bool CookieEnabled { get; set; }

        [SpParam(SqlParamName = "ip_DoNotTrack")]
        public bool DoNotTrack { get; set; }

        [SpParam(SqlParamName = "ip_SuperCookies")]
        public string SuperCookies { get; set; }

        [SpParam(SqlParamName = "ip_SystemTimeOffset")]
        public int SystemTimeOffset { get; set; }

        [SpParam(SqlParamName = "ip_Browser")]
        public string Browser { get; set; }

        [SpParam(SqlParamName = "ip_DeviceType")]
        public int DeviceType { get; set; }

        [SpParam(SqlParamName = "ip_Accept")]
        public string Accept { get; set; }

        [SpParam(SqlParamName = "ip_Headers")]
        public string Headers { get; set; }

        [SpParam(SqlParamName = "ip_Ip")]
        public string Ip { get; set; }

        [SpParam(SqlParamName = "ip_ScriptRequestedIp")]
        public string ScriptRequestedIp { get; set; }

        [SpParam(SqlParamName = "ip_SubscriberRecordedIp")]
        public string SubscriberRecordedIp { get; set; }

        [SpParam(SqlParamName = "ip_RemoteIps")]
        public string RemoteIps { get; set; }

        [SpParam(SqlParamName = "ip_LocalIps")]
        public string LocalIps { get; set; }

        [SpParam(SqlParamName = "ip_DomainName")]
        public string DomainName { get; set; }

        [SpParam(SqlParamName = "ip_DomainSameReferrer")]
        public bool DomainSameReferrer { get; set; }

        [SpParam(SqlParamName = "ip_HasDetail")]
        public bool HasDetail { get; set; }

        [SpParam(SqlParamName = "ip_DeviceIdIns")]
        public string DeviceIdIns { get; set; }

        [SpParam(SqlParamName = "ip_Error")]
        public string Error { get; set; }

        [SpParam(SqlParamName = "ip_Msg")]
        public string Msg { get; set; }

        public override string GetSettingKey()
        {
            return "FPS_DC_DeviceIdentity_Insert";
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
