using Fanex.Data;
using Fanex.Data.Repository;
using System;

namespace Fanex.WASA.FPS.Device.DataAccess.Criteria
{
    internal class InsNewDeviceCriteria : NonQueryCommand
    {
        [SpParam(SqlParamName = "ip_DeviceNo")]
        public string DeviceNo { get; set; }

        [SpParam(SqlParamName = "ip_DeviceType")]
        public int DeviceType { get; set; }

        [SpParam(SqlParamName = "ip_OsName")]
        public string OsName { get; set; }

        [SpParam(SqlParamName = "ip_SubscriberId")]
        public int SubscriberId { get; set; }

        [SpParam(SqlParamName = "ip_DeviceCode")]
        public string DeviceCode { get; set; }

        [SpParam(SqlParamName = "ip_Browser")]
        public string Browser { get; set; }

        [SpParam(SqlParamName = "ip_PluginId")]
        public long PluginId { get; set; }

        [SpParam(SqlParamName = "ip_CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [SpParam(SqlParamName = "ip_CapturedDate")]
        public DateTime CapturedDate { get; set; }

        [SpParam(SqlParamName = "op_DeviceId")]
        public int DeviceId { get; set; }

        public override string GetSettingKey()
        {
            return "";
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
