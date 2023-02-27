using System;

namespace Fanex.WASA.FPS.Evidence.Model.Entity
{
    public class PlaceEvidenceOnDevicesEntity
    {
        private readonly string deviceIds;
        private readonly string deviceNos;
        private readonly byte itemType;
        private readonly int eviId;
        private readonly int levelId;
        private readonly int subscriberId;
        private readonly bool isRetract;
        private readonly DateTime affectedDate;
        private readonly byte eviSource;

        public PlaceEvidenceOnDevicesEntity(string deviceIds, string deviceNos, byte itemType, int eviId, int levelId, int subscriberId, bool isRetract, DateTime affectedDate, byte eviSource)
        {
            this.deviceIds = deviceIds;
            this.deviceNos = deviceNos;
            this.itemType = itemType;
            this.eviId = eviId;
            this.levelId = levelId;
            this.subscriberId = subscriberId;
            this.isRetract = isRetract;
            this.affectedDate = affectedDate;
            this.eviSource = eviSource;
        }

        public string DeviceIds => deviceIds;

        public string DeviceNos => deviceNos;

        public byte ItemType => itemType;

        public int EviId => eviId;

        public int LevelId => levelId;

        public int SubscriberId => subscriberId;

        public bool IsRetract => isRetract;

        public DateTime AffectedDate => affectedDate;

        public byte EviSource => eviSource;
    }
}
