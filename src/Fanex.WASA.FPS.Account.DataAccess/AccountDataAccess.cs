using Fanex.Data;
using Fanex.Data.Repository;
using Fanex.WASA.FPS.Account.DataAccess.Criteria;
using Fanex.WASA.FPS.Account.Model.DTO;
using Fanex.WASA.FPS.Account.Model.Entity;
using Fanex.WASA.FPS.Evidence.Model.Entity;
using Fanex.WASA.FPS.Subcriber.Model.Entity;
using System.Collections.Generic;

namespace Fanex.WASA.FPS.Account.DataAccess
{
    public interface IAccountDataAccess
    {
        public AccountGetByUserNameDTO GetSubAccountByUsername(string username, int type);

        void InsertSubAccount(InsAccountDetailEntity entity);
    }

    public class AccountDataAccess : IAccountDataAccess
    {
        private readonly IDynamicRepository repository;

        public AccountDataAccess()
        {
            repository = new DynamicRepository();
        }

        public AccountGetByUserNameDTO GetSubAccountByUsername(string username, int type)
        {
            var criteria = new SubAccountGetByUsernameCriteria
            {
                Username = username,
                Type = type
            };

            var db = ObjectDbFactory.CreateInstance(criteria.GetSettingKey());
            var result = db.QueryMultiple(criteria);

            var accountEntityList = result.Read<AccountEntity, SubscriberEntity, AccountEntity>(
                    (accountEntity, subscriber) =>
                    {
                        accountEntity.Subscriber = subscriber;
                        return accountEntity;
                    },
                    "SubscriberID");

            var evidenceList = result.Read<EvidenceEntity>();
            var dto = new AccountGetByUserNameDTO
            {
                AccountEntityList = accountEntityList,
                EvidenceList = evidenceList
            };
            return dto;
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
