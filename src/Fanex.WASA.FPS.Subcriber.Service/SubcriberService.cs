using Fanex.WASA.FPS.Subcriber.DataAccess;
using Fanex.WASA.FPS.Subcriber.Model.DTO;

namespace Fanex.WASA.FPS.Subcriber.Service
{
    public interface ISubcriberService
    {
        public SubscriberGetByKeyDTO GetSubscriberByKey(string key);
    }

    public class SubcriberService : ISubcriberService
    {
        private readonly ISubcriberDataAccess subcriberDataAccess;

        public SubcriberService(ISubcriberDataAccess subcriberDataAccess)
        {
            this.subcriberDataAccess = subcriberDataAccess;
        }

        public SubscriberGetByKeyDTO GetSubscriberByKey(string key)
        {
            return subcriberDataAccess.GetSubscriberByKey(key);
        }
    }
}
