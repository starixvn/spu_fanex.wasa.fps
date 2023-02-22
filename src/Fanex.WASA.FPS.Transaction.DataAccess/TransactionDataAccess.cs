using Fanex.Data.Repository;
using Fanex.WASA.FPS.Transaction.DataAccess.Criteria;

namespace Fanex.WASA.FPS.Transaction.DataAccess
{
    public interface ITransactionDataAccess
    {
        void InsertSubTransactionByBatch(string transDoc);
    }

    public class TransactionDataAccess : ITransactionDataAccess
    {
        private readonly IDynamicRepository repository;

        public TransactionDataAccess()
        {
            repository = new DynamicRepository();
        }

        public void InsertSubTransactionByBatch(string transDoc)
        {
            var criteria = new SubTransactionByBatchInsert
            {
                TransDoc = transDoc
            };

            repository.Execute(criteria);
        }
    }
}
