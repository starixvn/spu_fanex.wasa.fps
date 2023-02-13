using Fanex.Data;
using Fanex.Data.Repository;

namespace Fanex.WASA.FPS.DI.DataAccess.Criteria
{
    class OffsetGetCriteria : NonQueryCommand
    {

        public override string GetSettingKey()
        {
            return "FPS_FP_Core_Offset_Get";
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
