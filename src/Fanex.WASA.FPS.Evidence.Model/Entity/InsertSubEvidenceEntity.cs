using System;

namespace Fanex.WASA.FPS.Evidence.Model.Entity
{
    public class InsertSubEvidenceEntity
    {
        private readonly int? itemId;
        private readonly string itemValue;
        private readonly int itemType;
        private readonly int eviId;
        private readonly int levelId;
        private readonly int subscriberId;
        private readonly DateTime affectedDate;
        private readonly byte eviSource;

        public InsertSubEvidenceEntity(int? itemId, string itemValue, int itemType, int eviId, int levelId, int subscriberId, DateTime affectedDate, byte eviSource)
        {
            this.itemId = itemId;
            this.itemValue = itemValue;
            this.itemType = itemType;
            this.eviId = eviId;
            this.levelId = levelId;
            this.subscriberId = subscriberId;
            this.affectedDate = affectedDate;
            this.eviSource = eviSource;
        }

        public int? ItemId => itemId;

        public string ItemValue => itemValue;

        public int ItemType => itemType;

        public int EviId => eviId;

        public int LevelId => levelId;

        public int SubscriberId => subscriberId;

        public DateTime AffectedDate => affectedDate;

        public byte EviSource => eviSource;
    }
}
