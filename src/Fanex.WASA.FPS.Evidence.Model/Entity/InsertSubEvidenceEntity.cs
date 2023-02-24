using System;

namespace Fanex.WASA.FPS.Evidence.Model.Entity
{
    public class InsertSubEvidenceEntity
    {
        public int? ItemId { get; set; }

        public string ItemValue { get; set; }

        public int ItemType { get; set; }

        public int EviId { get; set; }

        public int LevelId { get; set; }

        public int SubscriberId { get; set; }

        public DateTime AffectedDate { get; set; }

        public byte EviSource { get; set; }
    }
}
