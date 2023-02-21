using System;

namespace Fanex.WASA.FPS.Association.Model.Entity
{
    public class InsNewAssociationEntity
    {
        public int AccountId { get; set; }

        public int? DeviceId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastAccessedDate { get; set; }

        public int FpsAssId { get; set; }
    }
}
