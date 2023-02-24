using System;

namespace Fanex.WASA.FPS.Evidence.Model.Entity
{
    public class PlaceEvidenceOnAccountsEntity
    {
        public string AccountIds { get; set; }

        public string AccountNames { get; set; }

        public byte ItemType { get; set; }

        public int EviId { get; set; }

        public int LevelId { get; set; }

        public int SubscriberId { get; set; }

        public bool IsRetract { get; set; }

        public DateTime AffectedDate { get; set; }

        public byte EviSource { get; set; }
    }
}
