using System;

namespace Fanex.WASA.FPS.Account.Model.Entity
{
    public class InsAccountDetailEntity
    {
        private readonly string userName;
        private readonly string userName2;
        private readonly int subscriberId;
        private readonly DateTime createdDate;
        private readonly int accountId;

        public InsAccountDetailEntity(string userName, string userName2, int subscriberId, DateTime createdDate, int accountId)
        {
            this.userName = userName;
            this.userName2 = userName2;
            this.subscriberId = subscriberId;
            this.createdDate = createdDate;
            this.accountId = accountId;
        }

        public string UserName => userName;

        public string UserName2 => userName2;

        public int SubscriberId => subscriberId;

        public DateTime CreatedDate => createdDate;

        public int AccountId => accountId;
    }
}
