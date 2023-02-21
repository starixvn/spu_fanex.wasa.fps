using Fanex.WASA.FPS.Association.DataAccess;
using Fanex.WASA.FPS.Association.Model.Entity;

namespace Fanex.WASA.FPS.Association.Service
{
    public interface IAssociationService
    {
        void InsertSubAssociation(InsNewAssociationEntity entity);
    }

    public class AssociationService : IAssociationService
    {
        private readonly IAssociationDataAccess associationDataAccess;

        public AssociationService(IAssociationDataAccess associationDataAccess)
        {
            this.associationDataAccess = associationDataAccess;
        }

        public void InsertSubAssociation(InsNewAssociationEntity entity)
        {
            associationDataAccess.InsertSubAssociation(entity);
        }
    }
}
