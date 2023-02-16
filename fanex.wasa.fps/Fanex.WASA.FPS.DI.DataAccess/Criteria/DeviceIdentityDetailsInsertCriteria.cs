using Fanex.Data;
using Fanex.Data.Repository;

namespace Fanex.WASA.FPS.DI.DataAccess.Criteria
{
    public class DeviceIdentityDetailsInsertCriteria : NonQueryCommand
    {
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

        [SpParam(SqlParamName = "ip_Screen")]
        public string Screen { get; set; }

        [SpParam(SqlParamName = "ip_OS")]
        public string OS { get; set; }

        [SpParam(SqlParamName = "ip_Browser")]
        public string Browser { get; set; }

        [SpParam(SqlParamName = "ip_Engine")]
        public string Engine { get; set; }

        [SpParam(SqlParamName = "ip_DeviceName")]
        public string DeviceName { get; set; }

        [SpParam(SqlParamName = "ip_Accept")]
        public string Accept { get; set; }

        [SpParam(SqlParamName = "ip_Headers")]
        public string Headers { get; set; }

        [SpParam(SqlParamName = "op_DeviceCodeIns")]
        public string DeviceCodeIns { get; set; }

        [SpParam(SqlParamName = "op_Error")]
        public string Error { get; set; }

        [SpParam(SqlParamName = "op_Msg")]
        public string Msg { get; set; }

        public override string GetSettingKey()
        {
            return "FPS_DC_DeviceIdentity_Details_Insert";
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
