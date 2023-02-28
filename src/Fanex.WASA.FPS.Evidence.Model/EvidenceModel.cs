using Fanex.WASA.FPS.Evidence.Model.Entity;
using System;

namespace Fanex.WASA.FPS.Evidence.Model
{
    public class EvidenceModel : EvidenceEntity
    {
        public DateTime AffectedDate { get; set; }

        public EvidenceSource Source { get; set; }

        /// <summary>
        ///     Clones the current evidence node to a level specified.
        /// </summary>
        /// <param name="level">The level.</param>
        /// <returns>EvidenceNode object.</returns>
        public EvidenceModel CloneLevel(int level)
        {
            return new EvidenceModel
            {
                Id = Id,
                GroupId = GroupId,
                Code = Code,
                ItemValue = ItemValue,
                SubscriberId = SubscriberId,
                Level = level,
                AffectedDate = AffectedDate,
                Source = Source
            };
        }

        public int GetGroupId()
        {
            var splitChar = '.';
            return int.Parse(Code.Substring(0, Code.IndexOf(splitChar)));
        }
    }
}
