using Fanex.Data;
using Fanex.Data.Repository;
using System;

namespace Fanex.WASA.FPS.Evidence.DataAccess.Criteria
{
    internal class PlaceEvidenceOnDevicesCriteria : NonQueryCommand
    {
        [SpParam(SqlParamName = "ip_DeviceIds")]
        public string DeviceIds { get; set; }

        [SpParam(SqlParamName = "ip_DeviceNos")]
        public string DeviceNos { get; set; }

        [SpParam(SqlParamName = "ip_ItemType")]
        public int ItemType { get; set; }

        [SpParam(SqlParamName = "ip_EviId")]
        public int EviId { get; set; }

        [SpParam(SqlParamName = "ip_LevelId")]
        public int LevelId { get; set; }

        [SpParam(SqlParamName = "ip_SubscriberId")]
        public int SubscriberId { get; set; }

        [SpParam(SqlParamName = "ip_IsRetract")]
        public bool IsRetract { get; set; }

        [SpParam(SqlParamName = "ip_AffectedDate")]
        public DateTime AffectedDate { get; set; }

        [SpParam(SqlParamName = "ip_EviSource")]
        public byte EviSource { get; set; }

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