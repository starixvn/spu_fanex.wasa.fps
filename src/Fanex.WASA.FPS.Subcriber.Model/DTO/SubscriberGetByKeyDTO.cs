using Fanex.WASA.FPS.Evidence.Model;
using Fanex.WASA.FPS.Transaction.Model;
using System.Collections.Generic;

namespace Fanex.WASA.FPS.Subcriber.Model.DTO
{
    public class SubscriberGetByKeyDTO
    {
        public IEnumerable<Subscriber>? Subscriber { get; set; }
        public IEnumerable<TrustEvidence>? TrustEvidence { get; set; }
        public IEnumerable<FPSAction>? FPSAction { get; set; }
    }
}
