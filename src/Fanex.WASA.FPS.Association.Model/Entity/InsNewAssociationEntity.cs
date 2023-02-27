using System;

namespace Fanex.WASA.FPS.Association.Model.Entity
{
    public class InsNewAssociationEntity
    {
        private readonly int accountId;
        private readonly int? deviceId;
        private readonly DateTime createdDate;
        private readonly DateTime lastAccessedDate;
        private readonly int fpsAssId;

        public InsNewAssociationEntity(int accountId, int? deviceId, DateTime createdDate, DateTime lastAccessedDate, int fpsAssId)
        {
            this.accountId = accountId;
            this.deviceId = deviceId;
            this.createdDate = createdDate;
            this.lastAccessedDate = lastAccessedDate;
            this.fpsAssId = fpsAssId;
        }

        public int AccountId => accountId;

        public int? DeviceId => deviceId;

        public DateTime CreatedDate => createdDate;

        public DateTime LastAccessedDate => lastAccessedDate;

        public int FpsAssId => fpsAssId;
    }
}
