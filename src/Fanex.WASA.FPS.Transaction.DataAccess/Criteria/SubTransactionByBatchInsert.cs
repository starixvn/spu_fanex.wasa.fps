using Fanex.Data;
using Fanex.Data.Repository;

namespace Fanex.WASA.FPS.Transaction.DataAccess.Criteria
{
    internal class SubTransactionByBatchInsert : NonQueryCommand
    {
        [SpParam(SqlParamName = "ip_TransDoc")]
        public string TransDoc { get; set; }

        public override string GetSettingKey()
        {
            return "FPS_SUB_Transaction_By_Batch_Insert";
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}