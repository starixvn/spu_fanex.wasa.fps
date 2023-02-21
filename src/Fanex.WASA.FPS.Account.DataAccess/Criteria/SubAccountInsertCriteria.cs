using Fanex.Data;
using Fanex.Data.Repository;
using System;

namespace Fanex.WASA.FPS.Account.DataAccess.Criteria
{
    internal class SubAccountInsertCriteria : NonQueryCommand
    {
        [SpParam(SqlParamName = "ip_username")]
        public string Username { get; set; }

        [SpParam(SqlParamName = "ip_username2")]
        public string Username2 { get; set; }

        [SpParam(SqlParamName = "ip_subscriberId")]
        public int SubscriberId { get; set; }

        [SpParam(SqlParamName = "ip_createdDate")]
        public DateTime CreatedDate { get; set; }

        [SpParam(SqlParamName = "op_accountId")]
        public int AccountId { get; set; }

        public override string GetSettingKey()
        {
            return "FPS_SUB_Account_Insert";
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
