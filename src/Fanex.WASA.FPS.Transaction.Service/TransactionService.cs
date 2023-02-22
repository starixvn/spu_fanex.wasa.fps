using Fanex.WASA.FPS.Transaction.DataAccess;

namespace Fanex.WASA.FPS.Transaction.Service
{
    public interface ITransactionService
    {
        void InsertSubTransactionByBatch(string transDoc);
    }

    public class TransactionService : ITransactionService
    {
        private readonly ITransactionDataAccess transactionDataAccess;

        public TransactionService(ITransactionDataAccess transactionDataAccess)
        {
            this.transactionDataAccess = transactionDataAccess;
        }

        public void InsertSubTransactionByBatch(string transDoc)
        {
            transactionDataAccess.InsertSubTransactionByBatch(transDoc);
        }
    }
}
