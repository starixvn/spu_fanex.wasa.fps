using System;

namespace Fanex.WASA.FPS.Evidence.Model.Entity
{
    public class PlaceEvidenceOnAccountsEntity
    {
        private readonly string accountIds;
        private readonly string accountNames;
        private readonly byte itemType;
        private readonly int eviId;
        private readonly int levelId;
        private readonly int subscriberId;
        private readonly bool isRetract;
        private readonly DateTime affectedDate;
        private readonly byte eviSource;

        public PlaceEvidenceOnAccountsEntity(string accountIds, string accountNames, byte itemType, int eviId, int levelId, int subscriberId, bool isRetract, DateTime affectedDate, byte eviSource)
        {
            this.accountIds = accountIds;
            this.accountNames = accountNames;
            this.itemType = itemType;
            this.eviId = eviId;
            this.levelId = levelId;
            this.subscriberId = subscriberId;
            this.isRetract = isRetract;
            this.affectedDate = affectedDate;
            this.eviSource = eviSource;
        }

        public string AccountIds => accountIds;

        public string AccountNames => accountNames;

        public byte ItemType => itemType;

        public int EviId => eviId;

        public int LevelId => levelId;

        public int SubscriberId => subscriberId;

        public bool IsRetract => isRetract;

        public DateTime AffectedDate => affectedDate;

        public byte EviSource => eviSource;
    }
}
