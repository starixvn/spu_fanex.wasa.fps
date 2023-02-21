using Fanex.Data;
using Fanex.Data.Repository;
using System;

namespace Fanex.WASA.FPS.DI.DataAccess.Criteria
{
    internal class UpdDeviceCriteria : NonQueryCommand
    {
        [SpParam(SqlParamName = "ip_DeviceId")]
        public int DeviceId { get; set; }

        [SpParam(SqlParamName = "ip_CapturedDate")]
        public DateTime CapturedDate { get; set; }

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