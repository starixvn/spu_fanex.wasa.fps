using Fanex.Data.Repository;
using Fanex.WASA.FPS.DI.DataAccess.Criteria;
using Fanex.WASA.FPS.DI.Model;
using System.Collections.Generic;

namespace Fanex.WASA.FPS.DI.DataAccess
{
    public interface IOffsetDataAccess
    {
        IEnumerable<OffsetEntity> GetOffset();
    }

    public class OffsetDataAccess : IOffsetDataAccess
    {
        private readonly IDynamicRepository repository;

        public OffsetDataAccess()
        {
            repository = new DynamicRepository();
        }

        public IEnumerable<OffsetEntity> GetOffset()
        {
            var criteria = new OffsetGetCriteria
            {
            };

            return repository.Fetch<OffsetEntity>(criteria);
        }
    }
}
