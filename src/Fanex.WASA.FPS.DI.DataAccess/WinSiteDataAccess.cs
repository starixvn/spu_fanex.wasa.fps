using Fanex.Data.Repository;
using Fanex.WASA.FPS.DI.DataAccess.Criteria;
using Fanex.WASA.FPS.DI.Model;

namespace Fanex.WASA.FPS.DI.DataAccess
{
    public interface IWinSiteDataAccess
    {
        void InsertSubAccount(InsAccountDetailEntity entity);
    }

    public class WinSiteDataAccess : IWinSiteDataAccess
    {
        private readonly IDynamicRepository repository;

        public WinSiteDataAccess()
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
