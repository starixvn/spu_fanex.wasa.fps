using Fanex.Data;
using Fanex.Data.Repository;
using System;

namespace Fanex.WASA.FPS.Association.DataAccess.Criteria
{
    internal class SubAssociationInsertCriteria : NonQueryCommand
    {
        [SpParam(SqlParamName = "ip_DeviceID")]
        public int? DeviceID { get; set; }

        [SpParam(SqlParamName = "ip_AccountID")]
        public int AccountID { get; set; }

        [SpParam(SqlParamName = "ip_createdDate")]
        public DateTime CreatedDate { get; set; }

        [SpParam(SqlParamName = "ip_LastAccessedDate")]
        public DateTime LastAccessedDate { get; set; }

        [SpParam(SqlParamName = "op_FpsAssId")]
        public int FpsAssId { get; set; }

        public override string GetSettingKey()
        {
            return "FPS_SUB_Association_Insert";
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
