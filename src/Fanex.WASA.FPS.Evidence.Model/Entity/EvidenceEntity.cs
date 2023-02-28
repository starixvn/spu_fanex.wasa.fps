namespace Fanex.WASA.FPS.Evidence.Model.Entity
{
    public class EvidenceEntity
    {
        public string? Code { get; set; }

        public string? Name { get; set; }

        public int Id { get; set; }

        public int Level { get; set; }

        public int SubscriberId { get; set; }

        public int ItemId { get; set; }

        public string? ItemValue { get; set; }

        public int GroupId { get; set; }
    }
}
