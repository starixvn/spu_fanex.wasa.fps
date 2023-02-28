using Fanex.WASA.FPS.Evidence.Model;
using Fanex.WASA.FPS.Subcriber.Model.Entity;
using Fanex.WASA.FPS.Transaction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Fanex.WASA.FPS.Subcriber.Model
{
    public class Subscriber : SubscriberEntity
    {
        public bool Enable { get; set; }

        public bool EnableRuleSet { get; set; }

        public bool EnableSysId { get; set; }

        public bool IsTest { get; set; }

        public List<TrustEvidence> TrustEvidences { get; set; }

        public List<FPSAction> Actions { get; set; }

        public SubscriberEntity GetSubscriberEntity
        {
            get
            {
                return new SubscriberEntity
                {
                    Id = Id,
                    Name = Name,
                    SubscriberDate = SubscriberDate
                };
            }
        }

        public bool IsTrustEvidence(EvidenceModel evidenceNode)
        {
            var trustySub = TrustEvidences != null;
            if (!trustySub)
            {
                return trustySub;
            }

            // 1. get trust subscriber
            var trustEvidence = TrustEvidences
                .FirstOrDefault(e => e.SubscriberId == evidenceNode.SubscriberId && e.Enable);

            trustySub = trustEvidence != null;
            if (!trustySub)
            {
                return trustySub;
            }

            // 2. EvidenceCategoryId
            var trustyGroup = false;
            if (trustEvidence.GroupIds != null)
            {
                trustyGroup = trustEvidence.GroupIds.Contains(evidenceNode.GetGroupId());
            }

            // 3. EvidenceCodes
            var trustyCode = false;
            if (trustEvidence.Codes != null)
            {
                trustyCode = trustEvidence.Codes.Contains(evidenceNode.Code);
            }

            trustySub = trustyGroup || trustyCode;

            return trustySub;
        }
    }
}