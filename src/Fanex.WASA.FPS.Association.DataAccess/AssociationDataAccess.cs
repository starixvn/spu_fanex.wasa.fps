using Fanex.Data.Repository;
using Fanex.WASA.FPS.Association.DataAccess.Criteria;
using Fanex.WASA.FPS.Association.Model.Entity;

namespace Fanex.WASA.FPS.Association.DataAccess
{
    public interface IAssociationDataAccess
    {
        void InsertSubAssociation(InsNewAssociationEntity entity);
    }

    public class AssociationDataAccess : IAssociationDataAccess
    {
        private readonly IDynamicRepository repository;

        public AssociationDataAccess()
        {
            repository = new DynamicRepository();
        }

        public void InsertSubAssociation(InsNewAssociationEntity entity)
        {
            var criteria = new SubAssociationInsertCriteria
            {
                AccountID = entity.AccountId,
                CreatedDate = entity.CreatedDate,
                DeviceID = entity.DeviceId,
                LastAccessedDate = entity.LastAccessedDate,

                FpsAssId = entity.FpsAssId
            };

            repository.Execute(criteria);
        }
    }
}
