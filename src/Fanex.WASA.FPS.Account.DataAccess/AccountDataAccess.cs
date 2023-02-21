using Fanex.Data.Repository;
using Fanex.WASA.FPS.Account.DataAccess.Criteria;
using Fanex.WASA.FPS.Account.Model.Entity;

namespace Fanex.WASA.FPS.Account.DataAccess
{
    public interface IAccountDataAccess
    {
        void InsertSubAccount(InsAccountDetailEntity entity);
    }

    public class AccountDataAccess : IAccountDataAccess
    {
        private readonly IDynamicRepository repository;

        public AccountDataAccess()
        {
            repository = new DynamicRepository();
        }

        public void InsertSubAccount(InsAccountDetailEntity entity)
        {
            var criteria = new SubAccountInsertCriteria
            {
                AccountId = 0,
                CreatedDate = entity.CreatedDate,
                SubscriberId = entity.SubscriberId,
                Username = entity.UserName,
                Username2 = entity.UserName2
            };

            repository.Execute(criteria);
        }
    }
}
