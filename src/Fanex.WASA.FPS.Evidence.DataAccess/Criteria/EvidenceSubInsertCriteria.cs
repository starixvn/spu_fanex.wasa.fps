using Fanex.Data;
using Fanex.Data.Repository;
using System;

namespace Fanex.WASA.FPS.Evidence.DataAccess.Criteria
{
    internal class EvidenceSubInsertCriteria : NonQueryCommand
    {
        [SpParam(SqlParamName = "ip_ItemId")]
        public int? ItemId { get; set; }

        [SpParam(SqlParamName = "ip_ItemValue")]
        public string ItemValue { get; set; }

        [SpParam(SqlParamName = "ip_ItemType")]
        public int ItemType { get; set; }

        [SpParam(SqlParamName = "ip_EviId")]
        public int EviId { get; set; }

        [SpParam(SqlParamName = "ip_LevelId")]
        public int LevelId { get; set; }

        [SpParam(SqlParamName = "ip_SubscriberId")]
        public int SubscriberId { get; set; }

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