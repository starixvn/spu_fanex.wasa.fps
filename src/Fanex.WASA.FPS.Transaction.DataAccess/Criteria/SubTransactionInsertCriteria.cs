using Fanex.Data;
using Fanex.Data.Repository;
using System;

namespace Fanex.WASA.FPS.Transaction.DataAccess.Criteria
{
    internal class SubTransactionInsertCriteria : NonQueryCommand
    {
        [SpParam(SqlParamName = "ip_AccountID")]
        public int AccountID { get; set; }

        [SpParam(SqlParamName = "ip_DeviceID")]
        public int DeviceID { get; set; }

        [SpParam(SqlParamName = "ip_SubscriberID")]
        public int SubscriberID { get; set; }

        [SpParam(SqlParamName = "ip_TransDate")]
        public DateTime TransDate { get; set; }

        [SpParam(SqlParamName = "ip_ActionName")]
        public string ActionName { get; set; }

        [SpParam(SqlParamName = "ip_ActionResult")]
        public string ActionResult { get; set; }

        [SpParam(SqlParamName = "ip_IP")]
        public string IP { get; set; }

        [SpParam(SqlParamName = "ip_Country")]
        public string Country { get; set; }

        [SpParam(SqlParamName = "ip_CountryCode")]
        public string CountryCode { get; set; }

        [SpParam(SqlParamName = "ip_Region")]
        public string Region { get; set; }

        [SpParam(SqlParamName = "ip_City")]
        public string City { get; set; }

        [SpParam(SqlParamName = "ip_Browser")]
        public string Browser { get; set; }

        [SpParam(SqlParamName = "ip_PluginID")]
        public long PluginID { get; set; }

        [SpParam(SqlParamName = "ip_Flagged")]
        public int Flagged { get; set; }

        [SpParam(SqlParamName = "ip_RuleSetID")]
        public int RuleSetID { get; set; }

        [SpParam(SqlParamName = "ip_RuleVersionID")]
        public string RuleVersionID { get; set; }

        [SpParam(SqlParamName = "ip_RuleIds")]
        public string RuleIds { get; set; }

        [SpParam(SqlParamName = "ip_URL")]
        public string URL { get; set; }

        [SpParam(SqlParamName = "ip_ISP")]
        public string ISP { get; set; }

        [SpParam(SqlParamName = "ip_UserAgent")]
        public string UserAgent { get; set; }

        [SpParam(SqlParamName = "op_transid")]
        public int transid { get; set; }

        public override string GetSettingKey()
        {
            return "FPS_SUB_Transaction_Insert";
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
