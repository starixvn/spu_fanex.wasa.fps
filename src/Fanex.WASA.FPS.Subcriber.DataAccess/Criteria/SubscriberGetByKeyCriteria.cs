using Fanex.Data;
using Fanex.Data.Repository;

namespace Fanex.WASA.FPS.Subcriber.DataAccess.Criteria
{
    internal class SubscriberGetByKeyCriteria : CriteriaBase
    {
        [SpParam(SqlParamName = "ip_key")]
        public string? Key { get; set; }

        [SpParam(SqlParamName = "ip_isActive")]
        public bool IsActive { get; set; }

        public override string GetSettingKey()
        {
            return "FPS_DC_Subscriber_GetByKey";
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}