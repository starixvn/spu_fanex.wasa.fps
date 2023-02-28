using Fanex.Data;
using Fanex.Data.Repository;

namespace Fanex.WASA.FPS.Account.DataAccess.Criteria
{
    public class SubAccountGetByUsernameCriteria : CriteriaBase
    {
        [SpParam(SqlParamName = "ip_username")]
        public string? Username { get; set; }

        [SpParam(SqlParamName = "ip_type")]
        public int Type { get; set; }

        public override string GetSettingKey()
        {
            return "FPS_SUB_Account_GetByUserName";
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}