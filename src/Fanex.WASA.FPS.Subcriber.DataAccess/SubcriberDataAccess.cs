using Fanex.Data.Repository;
using Fanex.WASA.FPS.Evidence.Model;
using Fanex.WASA.FPS.Subcriber.DataAccess.Criteria;
using Fanex.WASA.FPS.Subcriber.Model;
using Fanex.WASA.FPS.Subcriber.Model.DTO;
using Fanex.WASA.FPS.Transaction.Model;

namespace Fanex.WASA.FPS.Subcriber.DataAccess
{
    public interface ISubcriberDataAccess
    {
        public SubscriberGetByKeyDTO GetSubscriberByKey(string key);
    }

    public class SubcriberDataAccess : ISubcriberDataAccess
    {
        private readonly IDynamicRepository repository;

        public SubcriberDataAccess()
        {
            repository = new DynamicRepository();
        }

        public SubscriberGetByKeyDTO GetSubscriberByKey(string key)
        {
            var criteria = new SubscriberGetByKeyCriteria
            {
                Key = key,
                IsActive = true
            };

            var (subscriber, trustEvidence, fpsAction) = repository.FetchMultiple<Subscriber, TrustEvidence, FPSAction>(criteria);

            return new SubscriberGetByKeyDTO
            {
                Subscriber = subscriber,
                TrustEvidence = trustEvidence,
                FPSAction = fpsAction
            };
        }
    }
}
