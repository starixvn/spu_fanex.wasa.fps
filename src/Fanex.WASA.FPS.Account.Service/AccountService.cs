using Fanex.WASA.FPS.Account.DataAccess;
using Fanex.WASA.FPS.Account.Model.Entity;

namespace Fanex.WASA.FPS.Account.Service
{
    public interface IAccountService
    {
        void InsertSubAccount(InsAccountDetailEntity entity);
    }

    public class AccountService : IAccountService
    {
        private readonly IAccountDataAccess accountDataAccess;

        public AccountService(IAccountDataAccess accountDataAccess)
        {
            this.accountDataAccess = accountDataAccess;
        }

        public void InsertSubAccount(InsAccountDetailEntity entity)
        {
            accountDataAccess.InsertSubAccount(entity);
        }
    }
}
